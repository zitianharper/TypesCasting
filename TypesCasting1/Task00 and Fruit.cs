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

            Console.WriteLine(myFruit1.GetType());
            Console.WriteLine("Do myFruit1 and myFruit2 have same reference: " + Fruit.ReferenceEquals(myFruit1, myFruit2));
            Console.WriteLine("Do myFruit1 and fruit1Copy have same reference: " + Fruit.ReferenceEquals(myFruit1, fruit1Copy));

        }
    }
}
