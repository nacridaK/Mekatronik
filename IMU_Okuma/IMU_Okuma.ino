#define _USE_MATH_DEFINES
#include <Wire.h>
#include <math.h>
void setup()
{
  Wire.begin();
  Wire.beginTransmission(0x68);
  Wire.write(0x6B);
  Wire.write(0);
  Wire.endTransmission(true);
  Serial.begin(9600);
}
void loop()
{
  Serial.print(acc2deg());
  Serial.print('\t');
  Serial.println(gyro2deg(100));
}

float acc2deg()
{
  Wire.beginTransmission(0x68);
  Wire.write(0x3B);
  Wire.endTransmission(false);
  Wire.requestFrom(0x68, 4, true);

  int acc_x = Wire.read() << 8 | Wire.read();
  float a_x = acc_x / 16384.0;
  
  int acc_y = Wire.read() << 8 | Wire.read();
  float a_y = acc_y / 16384.0;

  return 180 * atan(a_x / a_y) / M_PI;
}
float gyro2deg(int lag)
{
  Wire.beginTransmission(0x68);
  Wire.write(0x43);
  Wire.endTransmission(false);
  static float y = 0;
  
  Wire.requestFrom(0x68, 2, true);
  int gyro1_x = Wire.read() << 8 | Wire.read();
  float g1_x = gyro1_x / 131.0;

  delay(lag);

  Wire.requestFrom(0x68, 2, true);
  int gyro2_x = Wire.read() << 8 | Wire.read();
  float g2_x = gyro2_x / 131.0;

  y = 0.0005 * lag * (g2_x + g1_x) + y;
  return y;
}
