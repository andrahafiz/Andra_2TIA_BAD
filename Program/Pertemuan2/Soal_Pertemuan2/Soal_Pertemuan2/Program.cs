using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Versi 1
            List<String> ListNama = new List<string>();
            Console.WriteLine("Masukan 5 Nama - nama hewan");
            for (int i=0; i < 5; i++)
            {
                Console.Write("Hewan " + (i+1) + " = ");
                ListNama.Add(Console.ReadLine());
            }

            Console.WriteLine("\nHapus dengan hewan namaVar.Remove(\"Value\") = ");
            ListNama.Remove(Console.ReadLine());
            foreach (string i in ListNama)
                Console.WriteLine("Nama hewan terdaftar " + i);

            Console.WriteLine("\nHapus dengan hewam namaVar.RemoveAt(indeks) = ");
            ListNama.RemoveAt(int.Parse(Console.ReadLine()));
            for (int i = 0; i < ListNama.Count; i++)
            {
                Console.WriteLine("Hewan indeks  = " + ListNama[i]);
             
            }

           Console.ReadLine();

        }
    }
}