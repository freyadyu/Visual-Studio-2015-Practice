using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        //k is defined outside of the scope.
        //private static string k = ""; // creating a field. static ==> plan to use it in other place

        static void Main(string[] args)
        {
            /*
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {

                    string l = i.ToString();

                }

                //Console.WriteLine("l: " + l); // l doesn't exit in current context

            }

            // Console.WriteLine(i); //cannot read i, because it's created in the scope
            //This is how we correct it.
            Console.WriteLine("Outside of the for: " + j);
            //Console.WriteLine("k: " + k);
            helperMethod();
            */

            Car car = new Car();

            car.DoSomething();
            //cannot access private method from other class

            Console.ReadLine();
        }

        /*
        static void helperMethod()
        {
            Console.WriteLine("k from the helerMethod: " + k);
        }
        */

    }

    class Car
    {
        public void DoSomething()
        {
            Console.Write(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
