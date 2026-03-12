using System;
using System.Collections.Generic;
using System.Text;

namespace TypesCasting1
{
     class Fruit
    {
        public string Name { get; set; }   // property
        public string Colour { get; set; } // property

        static public void SayHello()
        {
            Console.WriteLine("Hello from a fruit!");
        }
    }


    internal class Task00
    {
       public static void Run()
        {
            Fruit myFruit1 = new Fruit();
        }
    }
}
