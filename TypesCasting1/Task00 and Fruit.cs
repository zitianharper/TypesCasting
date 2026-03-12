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
        public static void MakeFruit()
        {
            Fruit myFruit1 = new Fruit(); // original instance
            Fruit myFruit2 = new Fruit(); //create a new instance
            Fruit fruit1Copy = myFruit1; // points to the original instance in memory
        }
    }
}
