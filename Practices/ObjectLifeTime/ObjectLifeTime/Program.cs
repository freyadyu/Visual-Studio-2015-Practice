using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instance
            Car myCar = new Car();
            // create a memory in computer that large 
            //enough to hold the new instance of Car class, myCar simply hold the
            //address that referrence to the instance of car Class

            Car myOtherCar = myCar; // two references to same memory, either one
            // can access the prop, method and memorty

            Car myThirdCar = new Car("Ford", "Escape", 2005, "silver");

            myOtherCar = null;
            myCar = null;

            //the static method allow class to directly use it w/o creating
            //new object to use it
            Car.MyMethod(); //

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            // you could load this from a configuration file, a databases, etc.
            // I'll just hardcode in this instance
            this.Make = "Nissan";

        }

        //Overloading constructor must have different method signuatre
        public Car (string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        /* wrong bc of same signature as above
        public Car(string someOtherInputParameter, string model, int year, string color)
        {
            Make = someOtherInputParameter;
            Model = model;
            Year = year;
            Color = color;
        }
        */

        public static void MyMethod()
        {

        }

    }

}
