using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka;

            Console.WriteLine("Silahkan inputkan angka antara 0 dan 10 : ");
            angka = int.Parse(Console.ReadLine());

            if (angka > 10)
                Console.WriteLine("Hi! Angka yang diinputkan harus antara 0 dan 10");
            else if (angka < 0)
                Console.WriteLine("Hi! Angka yang diinputkan harus besar dari 0");
            else
                Console.WriteLine("Mantul Gan!!!");

            Console.ReadLine();
        }
    }
}