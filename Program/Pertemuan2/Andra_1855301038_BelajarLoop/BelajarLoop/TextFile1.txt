using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BelajarLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ricky");
            list.Add("Lee");
            list.Add("Rina");

            foreach (string nama in list)
                Console.WriteLine("Nama dalam list : " + nama);

            Console.ReadLine();
        }
    }
}
