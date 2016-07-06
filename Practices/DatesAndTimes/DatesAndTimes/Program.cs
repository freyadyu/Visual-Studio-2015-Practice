using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //add and substract date and times
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthday = new DateTime(1969, 12, 7);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("12/7/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday); // subtract the DOB to get already lived days
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();

        }
    }
}
