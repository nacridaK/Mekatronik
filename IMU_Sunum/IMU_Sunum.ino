#include <MPU9255.h>
#include <math.h>

#define DEBUG false
#define LAG 20

union Eksen
{
  float aci;
  byte baytlar[4];
};

MPU9255 sensor;

Eksen x;
Eksen y;
Eksen z;

float aci_x = 0;
float aci_y = 0;
float aci_z = 0;
float gyro_x1, gyro_y1, gyro_z1;
float gyro_x2, gyro_y2, gyro_z2;
float acc_x, acc_y, acc_z;

byte katsayi;

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
  GyroAciOku();
  AccAciOku();
  Integral();
  katsayi = Filtre();
  Debug();
}

void AccAciOku()
{
  sensor.read_acc();
  acc_x = 180 * asin(1.0 * sensor.az / sensor.ay) / M_PI;
  acc_y = 180 * atan(1.0 * sensor.ax / sensor.az) / M_PI;
  acc_z = 180 * atan(1.0 * sensor.ax / sensor.ay) / M_PI;
}

void GyroAciOku()
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

void Integral()
{
  aci_x = LAG * 0.0005 * (gyro_x2 + gyro_x1) + aci_x;
  aci_y = LAG * 0.0005 * (gyro_y2 + gyro_y1) + aci_y;
  aci_z = LAG * 0.0005 * (gyro_z2 + gyro_z1) + aci_z;
}

byte Filtre()
{
  float katsayi = analogRead(A0) / 1023.0;
  aci_x = (1 - katsayi) * aci_x + katsayi * acc_x;
  aci_y = (1 - katsayi) * aci_y + katsayi * acc_y;
  aci_z = (1 - katsayi) * aci_z + katsayi * acc_z;
  return 100 * katsayi;
}
void Debug()
{
  if (DEBUG)
  {
    Serial.print(katsayi);
    Serial.print('\t');
    Serial.print(aci_x);
    Serial.print('\t');
    Serial.print(aci_y);
    Serial.print('\t');
    Serial.println(aci_z);
  }
  else
  {
    x.aci = aci_x;
    for (int i = 0; i < 4; i++)
      Serial.write(x.baytlar[i]);
    y.aci = aci_y;
    for (int i = 0; i < 4; i++)
      Serial.write(y.baytlar[i]);
    z.aci = aci_z;
    for (int i = 0; i < 4; i++)
      Serial.write(z.baytlar[i]);
    Serial.write(katsayi);
  }
}

