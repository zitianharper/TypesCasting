using static System.Net.Mime.MediaTypeNames;

namespace TypesCasting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task01.Run();
            Task01.Tests("11111");
            Task01.Test32("9738");

            double num1 = 2.2;
            decimal num2 = 4.9m;

            int newNum1 = (int)num1;
            int newNum2 = (int)num2;

            Task01.MultiplyInt(newNum1, newNum2);

            Fruit.SayHello();


            Fruit.MakeFruit();

            divideByDouble();




        }

        public static void divideByDouble()
        {

            Console.WriteLine("Please input a full number:");
            int intInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input a decimal number");
            decimal decInput = decimal.Parse(Console.ReadLine());

            double doubleResult = (double)(intInput / decInput);

            Console.WriteLine("You would like a character (true/false):");
            string response = Console.ReadLine();
            if (response == "true")
            {

                char[] charResult = doubleResult.ToString().ToCharArray();
                
                foreach (char number in charResult)
                {
                    Console.WriteLine($"\n {number}");
                }
            }
            else {
                Console.WriteLine(doubleResult);
            }
        }
        

    }
}
