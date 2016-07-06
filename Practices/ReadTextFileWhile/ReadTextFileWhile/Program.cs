using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt"); //files cannot be found in bin folder
            string line = "";

            while (line != null) //iterate through the whole file
            {
                line = myReader.ReadLine(); //set line to be message
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close(); //close StreamReader
            Console.ReadLine();

        }
    }
}
