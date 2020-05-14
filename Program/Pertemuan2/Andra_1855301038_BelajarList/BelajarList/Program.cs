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
            List<String> ListNama = new List<string>()
            { "Budi","Hasan","Santoso"};
            Console.WriteLine("Isi dari list indesk ke 0: " + ListNama[0]);

            //Versi 2
            var angka1 = new List<int>();
            angka1.Add(2);
            angka1.Add(3);
            angka1.Add(5);
            angka1.Add(7);
            Console.WriteLine("Total isi list 1 : " + angka1.Count);

            //Versi 3
            var angka2 = new List<int>() { 2, 3, 5, 7 };
            Console.WriteLine("Total isi list 2: " + angka2.Count);

            Console.ReadLine();

            /*untuk menghapus ada tiga cara
             1. namaVar.Remove("Value")
             2. namaVar.RemoveAt(indeks)
             3. namaVar.RemoveAll()*/

        }
    }
}
