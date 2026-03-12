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
    }

        
}
