using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Versi 1
            Dictionary<string, int> nama = new Dictionary<string, int>();
            nama.Add("Budi Santoso", 42);
            nama.Add("Iwan Handoko", 38);
            nama.Add("Rini Sulastri", 12);
            nama.Add("Tatik Lestari", 12);
            Console.WriteLine("Versi 1");
            Console.WriteLine("Budi Santoso berusia " + nama["Budi Santoso"]+ " Tahun");

            //Versi 2
            Console.WriteLine("Versi 2");
            string key = "Iwan Handoko";
            if (nama.ContainsKey(key))
                Console.WriteLine("Iwan Handoko" + nama.ContainsKey(key) + " tahun");

            //Versi 3
            Console.WriteLine("Versi 3");
            foreach(KeyValuePair<string, int> user in nama)
            {
                Console.WriteLine(user.Key + " berusia " + user.Value + " tahun");
            }

            Console.ReadLine();

        }
    }
}
