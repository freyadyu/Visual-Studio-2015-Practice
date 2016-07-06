using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;
            //myCar.TowingCapacity = 1200; cannot do this.

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            //all attributes for Car applies to Truck
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();

        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());
        }

        // you have to implement this
        abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public abstract string FormatMe();

        }

        class Car : Vehicle
        {
           
            public override string FormatMe()
            {
                return String.Format("{0} - {1} -  {2} - {3}",
                    this.Make,
                    this.Model,
                    this.Color,
                    this.Year);

            }

        }

        sealed class Truck : Vehicle //Truck is a type of Car, a version of type syntax, refer to the base
            //class or direct class Truck : subclass, Car : base class
        {
            public int TowingCapacity { get; set; }

            public override string FormatMe()
            {
                return String.Format("{0} - {1} -  {2} Towing units",
                    this.Make,
                    this.Model,
                    this.TowingCapacity);

            }

        }

        /* it cannot inheritance Truck bc Truck is sealed class
        class Semi : Truck
        {

        }
        */

    }
}
