﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apakah C# menarik ? (ya/tidak/biasa)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "ya":
                case "biasa":
                    Console.WriteLine("Luar biasa!");
                    break;
                case "tidak":
                    Console.WriteLine("Yah, sayang banget!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
