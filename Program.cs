using System;
using System.Threading;
using Pins;


namespace ESP32_WROOM_32_PINS
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("==============================================================");
            Console.WriteLine("            ESP32 Wroom 32 default mapped pins");
            Console.WriteLine("==============================================================" + "\n\n");


            // SPI 

            Console.WriteLine("SPI Device" + "\n");

            Console.WriteLine("SPI device name =  " + ESP32Device.SP1.Name);

            Console.WriteLine("MOSI pin =  " + ESP32Device.SP1.MOSI);

            Console.WriteLine("MISO pin =  " + ESP32Device.SP1.MISO);

            Console.WriteLine("SLK pin = " + ESP32Device.SP1.SCK + "\n\n");



            // Serial

            Console.WriteLine("Serial Device" + "\n");

            // COM1

            Console.WriteLine("Serial COM1 device name = " + ESP32Device.Serial.COM1.Name);

            Console.WriteLine("Serial RX pin = " + ESP32Device.Serial.COM1.RX);

            Console.WriteLine("Serial TX pin = " + ESP32Device.Serial.COM1.TX + "\n");

            // COM2

            Console.WriteLine("Serial COM2 device name = " + ESP32Device.Serial.COM2.Name);

            Console.WriteLine("Serial RX pin = " + ESP32Device.Serial.COM2.RX);

            Console.WriteLine("Serial TX pin = " + ESP32Device.Serial.COM2.TX + "\n");

            // COM3

            Console.WriteLine("Serial COM2 device name = " + ESP32Device.Serial.COM3.Name);

            Console.WriteLine("Serial RX pin = " + ESP32Device.Serial.COM3.RX);

            Console.WriteLine("Serial TX pin = " + ESP32Device.Serial.COM3.TX + "\n\n");

            // I2C

            Console.WriteLine("I2C Device" + "\n");

            // I2C1

            Console.WriteLine("I2C I2C1 device name = " + ESP32Device.I2C.I2C1.Name);

            Console.WriteLine("I2C Data pin = " + ESP32Device.I2C.I2C1.DATA);

            Console.WriteLine("I2C Clock pin = " + ESP32Device.I2C.I2C1.ClOCK + "\n");

            // I2C2

            Console.WriteLine("I2C I2C2 device name = " + ESP32Device.I2C.I2C2.Name);

            Console.WriteLine("I2C Data pin = " + ESP32Device.I2C.I2C2.DATA);

            Console.WriteLine("I2C Clock pin = " + ESP32Device.I2C.I2C2.ClOCK);
                                                

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
