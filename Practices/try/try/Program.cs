using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "df";
            var kk =   s ?? "no value";
            /* equal to 
            if (s == null)
                Console.WriteLine("no Value");
            else 
                Console.WriteLine(s);
             */
            Console.WriteLine(kk);
            Console.ReadLine();
            StringBuilder myString = new StringBuilder();
            myString.Append("a");

            try
            {

            }
            catch (Exception)
            {

                throw; // keyword
            }
            finally
            {

            }


            //String.IsNullOrEmpty(s);

        }
    }
}
