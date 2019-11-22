#include <MPU9255.h>
#include <math.h>

#define DEBUG false
#define LAG 25

union Data
{
  float angle;
  byte bytes[4];
};

MPU9255 sensor;

Data x;
Data y;
Data z;

Data Ax;
Data Ay;
Data Az;

float ang_x = 0;
float ang_y = 0;
float ang_z = 0;
float gyro_x1, gyro_y1, gyro_z1;
float gyro_x2, gyro_y2, gyro_z2;
float acc_x, acc_y, acc_z;

byte gain;

void setup()
{
  pinMode(A0, INPUT);
  sensor.init();
  sensor.set_gyro_scale(scale_250dps);
  sensor.set_acc_scale(scale_2g);
  Serial.begin(9600);
}

void loop()
{
  gyro2angle();
  acc2angle();
  integral();
  gain = filter();
  debug();
}

void gyro2angle()
{
  sensor.read_gyro();
  gyro_x1 = sensor.gx / 131.0;
  gyro_y1 = sensor.gy / 131.0;
  gyro_z1 = sensor.gz / 131.0;
  delay(LAG);
  gyro_x2 = sensor.gx / 131.0;
  gyro_y2 = sensor.gy / 131.0;
  gyro_z2 = sensor.gz / 131.0;
}
void acc2angle()
{
  sensor.read_acc();
  acc_x = -180 * atan2(sensor.az, sensor.ay) / M_PI;
  acc_y = -180 * atan2(sensor.ax, sensor.az) / M_PI;
  acc_z = 180 * atan2(sensor.ax, sensor.ay) / M_PI;
  //  acc_x = 180 * atan(1.0 * sensor.az / sensor.ay) / M_PI;
  //  acc_y = 180 * atan(1.0 * sensor.ax / sensor.az) / M_PI;
  //  acc_z = 180 * atan(1.0 * sensor.ax / sensor.ay) / M_PI;
}
void integral()
{
  ang_x = LAG * 0.0005 * (gyro_x2 + gyro_x1) + ang_x;
  ang_y = LAG * 0.0005 * (gyro_y2 + gyro_y1) + ang_y;
  ang_z = LAG * 0.0005 * (gyro_z2 + gyro_z1) + ang_z;
}

byte filter()
{
  float gain = analogRead(A0) / 1023.0;
  ang_x = (1 - gain) * ang_x + gain * acc_x;
  ang_y = (1 - gain) * ang_y + gain * acc_y;
  ang_z = (1 - gain) * ang_z + gain * acc_z;
  return 100 * gain;
}
void debug()
{
  if (DEBUG)
  {
    Serial.print("Filtered data:\t");
    Serial.print(gain);
    Serial.print('\t');
    Serial.print(ang_x);
    Serial.print('\t');
    Serial.print(ang_y);
    Serial.print('\t');
    Serial.println(ang_z);
    Serial.print("Acc. data:\t");
    Serial.print(gain);
    Serial.print('\t');
    Serial.print(acc_x);
    Serial.print('\t');
    Serial.print(acc_y);
    Serial.print('\t');
    Serial.println(acc_z);
  }
  else
  {
    x.angle = ang_x;
    for (int i = 0; i < 4; i++)
      Serial.write(x.bytes[i]);
    y.angle = ang_y;
    for (int i = 0; i < 4; i++)
      Serial.write(y.bytes[i]);
    z.angle = ang_z;
    for (int i = 0; i < 4; i++)
      Serial.write(z.bytes[i]);
    Ax.angle = acc_x;
    for (int i = 0; i < 4; i++)
      Serial.write(Ax.bytes[i]);
    Ay.angle = acc_y;
    for (int i = 0; i < 4; i++)
      Serial.write(Ay.bytes[i]);
    Az.angle = acc_z;
    for (int i = 0; i < 4; i++)
      Serial.write(Az.bytes[i]);
    Serial.write(gain);
  }
}
