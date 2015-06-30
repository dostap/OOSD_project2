// Author: Darya Ostapenko
// Date June 29, 2015
// Usage: Workshop 1. Main program tests package class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2Wkp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Package pk1 = new Package();
            Console.WriteLine(pk1 +"\n");

            Package pk2 = new Package(7, "NY adventure", "expedition + party", new DateTime(2015,09,21), new DateTime(2015,09,28), 25630.89m);
            Console.WriteLine(pk2);

            Console.WriteLine("\n\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
