using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive"; //slash problem \ scale character to produce other special 
            //character in command  \\ produce one single \
            //string myString = "My \"so called\" life"; // use \ for double quote inside double quotes
            //string myString = "What if I need \n a new line?";

            //string myString = string.Format("{0}!", "Bonzai");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");

            //string myString = string.Format("{0:C}", 123.45); //can have custom setting => $123.45
            //string myString = string.Format("{0:N}", 123456789); // ==>123,456,789.00 changed to float
            //string myString = string.Format("{0:P}", .123); //percentage => 12.3%
            //string myString = string.Format("Phone number: {0: (###) ###-#####}", 1234567890);

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                // myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString(); //same as above string concatenation or string builder
            }
            */

            /*
            StringBuilder myString = new StringBuilder(); // the performer will improve

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */

            string myString = " That summer we took threes across the board ";
            //myString = myString.Substring(5, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            myString = String.Format("Length before: {0} -- After: {1}",
                myString.Length, myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
