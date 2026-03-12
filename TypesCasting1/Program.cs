using static System.Net.Mime.MediaTypeNames;

namespace TypesCasting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task00.Run();
            Task01.Run();
            Task01.Tests("11111");
            Task01.Test32("9738");

            double num1 = 2.2;
            decimal num2 = 4.9m;

            int newNum1 = (int)num1;
            int newNum2 = (int)num2;

            Task01.MultiplyInt(newNum1, newNum2);

            int number = 500;   



            
            Console.WriteLine("Please input a full number:");
            int intInput = Console.Readline();
            Console.WriteLine("Please input a decimal number");
            decimal decInput = Console.ReadLine();

            decimal decimalIntInput = (decimal)intInput;

            decimal product = decimalIntInput / decInput;

            double productToDouble = (double)product;

            Console.WriteLine(productToDouble);

           Console.WriteLine("hello, input a number");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine($"{input} is not a number");
            }
            else
            {
                Console.WriteLine($"{number} is a number");
            }
        }
    }
}
