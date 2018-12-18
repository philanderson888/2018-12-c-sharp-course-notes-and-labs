using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // 32 bit default
            int num01;
            // 16 bit
            short num02;
            // 64 bit
            long num03;

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            uint num04;
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            // decimal types
            // 32 bit
            float num05 = 1.2345F;
            // 64 bit; default
            double num06 = 1.2345;
            // 128 bit plus MONEY EXACTLY 
            decimal num09 = 1.2345M;

            string string01 = "abc";
            // string is same as an array of characters
            // ASCII ==> 0-127 basic characters
            // UNICODE UTF-8 : similar to ASCII
            // UNICODE UTF-16 : C# : Represent basic English Plus
            // characters from around the world eg Chinese 
            char char01 = 'f';
            char char02 = (char)102;
            Console.WriteLine(char01);
            Console.WriteLine(char02);


        }
    }
}
