using System;

namespace Constructor
{
    class Car
    {
         string name;
         int price;
        
        Car(string theName, int thePrice)
        {
            theName = name;
            thePrice = price;
        }

        static void Main(string[] arg)
        {
            Car car1 = new Car("Fortuna", 120000);

            Console.WriteLine($"the name of the car is {car1.name},and the price is {car1.price}");
        }
    }
}


