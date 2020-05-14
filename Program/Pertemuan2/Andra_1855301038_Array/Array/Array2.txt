using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[2];

            nama[0] = "Budi Susanti";
            nama[1] = "Rina Sukawati";
            Console.WriteLine("Berikut nama dari Array : ");
            foreach (string s in nama)
                Console.WriteLine("-->" + s);
            Console.ReadLine();
        }
    }
}
