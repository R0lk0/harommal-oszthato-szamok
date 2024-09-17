using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harommal_oszthato_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hárommal osztható számok 1-től 20-ig.");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam <= 1 || szam <= 20)
            {
                if (szam % 3 == 0)
                {
                    Console.WriteLine("A szám osztható hárommal.");
                }
                else
                {
                    Console.WriteLine("A szám nem osztható hárommal. ");
                }
            }
            else
            {
                Console.WriteLine("A szám nem felel meg az értékhatároknak.");
            }
        }
    }
}
