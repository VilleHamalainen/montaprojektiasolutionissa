using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvo = 1;
            string input;
            RecursiveMethod(arvo);
            input = RecursiveMethod2();
            Console.ReadKey();
        }

        private static void RecursiveMethod(int arvo)
        {
            bool recursionRuns = true;
            int value = arvo;
            while (recursionRuns && value <10) { 
            
            value++;
            Console.WriteLine("Tämä on rekursio?");
            RecursiveMethod(value);
            }
        }

        private static string RecursiveMethod2()
        {
            Console.WriteLine("Valitse arvo");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                default:
                    RecursiveMethod2();
                    break;

            }
            return input;
        }
    }
}
