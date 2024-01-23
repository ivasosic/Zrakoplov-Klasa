using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZrakoplovKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000, 0, 200);
            


            Console.Write(x380.ToString());
            Console.ReadKey();

        }
    }
}
