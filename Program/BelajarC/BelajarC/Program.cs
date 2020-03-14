using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarC
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloTeman(0);
            HaloTeman(2, "Ani", "Toni", "Budi");
            Console.ReadKey();
        }

        static void HaloTeman(int parameterTambahan, params string[] names)
        {
            foreach (string name in names)
                Console.WriteLine("Halo, " + name);
        }
    }
}
