using System;
using System.Collections.Generic;
using System.Text;

namespace TypesCasting1
{
    internal class Task01
    {
        public static void Run()
        {
            float Float = 3.80f;
            string String = "h";
            double Double = 2.5;

            float number = 2.01f;

            decimal decimalNum = (decimal)number;

            Console.WriteLine(decimalNum);

            float twoPointNine = 2.9f;
            decimal maybeTwo = (decimal)twoPointNine;
            Console.WriteLine(maybeTwo);

            double longNumber = 3.678908765436578;
            float differentNumber = (float)longNumber;

            Console.WriteLine(differentNumber);

    
        }
        //task 4

        public static void MultiplyInt(int num1, int num2)
        {
            Console.WriteLine(num1 * num2); 
        }

        //task 5 
        public static void Tests(string test1)
        {
            
            int newTest1 = int.Parse(test1);

            Console.WriteLine(newTest1);
        }

        public static void Test32(string test2)
        {

            int newTest2 = Convert.ToInt32(test2);

            Console.WriteLine(test2);
        }

        public static void Parse(string test3)
        {

            int newTest3 = Int32.Parse(test3);

            Console.WriteLine(test3);
        }


    }



}
