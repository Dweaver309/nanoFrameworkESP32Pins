using System;

namespace Pins
{

    public static class ESP32Device
    {
        public static class SP1
        {
            public const string Name = "SPI1";
            public const int MOSI = 23;
            public const int MISO = 25;
            public const int SCK = 19;

        }

        public static class Serial
        {
            public static class COM1
            {
                public const string Name = "COM1";
                public const int TX = 1;
                public const int RX = 3;
                         
            }

            public static class COM2
            {
                public const string Name = "COM2";
                public const int TX = 10;
                public const int RX = 9;

            }

            public static class COM3
            {
                public const string Name = "COM3";
                public const int TX = 17;
                public const int RX = 16;

            }

        }
        public static class I2C
        {
            public static class I2C1
            {
                public const string Name = "I2C1";
                public const int DATA = 18;
                public const int ClOCK = 19;
             
            }

            public static class I2C2
            {
                public const string Name = "I2C2";
                public const int DATA = 25;
                public const int ClOCK = 26;

            }
        }
    }

}

