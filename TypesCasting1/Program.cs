namespace TypesCasting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task00.Run();
            Task01.Run();

            double num1 = 2.2;
            decimal num2 = 4.9m;

            int newNum1 = (int)num1;
            int newNum2 = (int)num2;

            Task01.MultiplyInt(newNum1, newNum2);
        }
    }
}
