using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");

            #region variables and literals
            //bool variable
            bool isAlive = true; //=1
            bool isDead = false; //=0
            #endregion

            #region inuteger
            // byte 0-255
            byte byte1 = 1;
            byte byte2 = 100;
            
            //sbyte -128-127
            sbyte sbyte1 = -5;
            sbyte sbyte2 = 127;

            //short = 2byte = -2^15 = -32768 - 32767
            short short1 = 15000;
            // ushort =2^16-1 = 0-65535
            short short2 = 15000;

            //int = 4byte = -2^31 - 2^31-1 = -2147483648 -2147483647
            int a = 10;
            //uint = 0-4 294 967 195
            uint b = 15;

            // long = 8byt - enough

            //float =4byte = -3.4*10^38 - 3.4*10^38 
            float fl = 0.222f;

            //double 8byte = +-5*10^(-324) - +-1.7*10^308

            //decimal 16byte - 28 number aftr dot
            decimal d = 0.3m;
            #endregion

            // unicode symbal - 2byte
            char symb = 'a';

            //string link type
            string hello = "hello";

            object obj = 1;
            object obj2 = "";

        }
    }
}
