# nanoFrameworkESP32Pins
ESP32 Wroom 32 nanoFramework mapped pins. 
Adding Pins.cs to a project makes finding the default pin for the ESP32 device much easier.
Just add Pins.cs to the project and add a reference to pins. The Visual Studio output should 
look like this.
==============================================================
            ESP32 Wroom 32 default mapped pins
==============================================================


SPI Device

SPI device name =  SPI1
MOSI pin =  23
MISO pin =  25
SLK pin = 19


Serial Device

Serial COM1 device name = COM1
Serial RX pin = 3
Serial TX pin = 1

Serial COM2 device name = COM2
Serial RX pin = 9
Serial TX pin = 10

Serial COM2 device name = COM3
Serial RX pin = 16
Serial TX pin = 17


I2C Device

I2C I2C1 device name = I2C1
I2C Data pin = 18
I2C Clock pin = 19

I2C I2C2 device name = I2C2
I2C Data pin = 25
I2C Clock pin = 26

