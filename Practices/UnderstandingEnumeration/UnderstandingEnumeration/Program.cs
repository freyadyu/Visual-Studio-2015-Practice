using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Type in a superhero's name to see his nickname:");
            string userValue = Console.ReadLine();

            //Console.WriteLine("Hello World!");

            SuperHero myValue;

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Doesn not compute");
            }

            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
