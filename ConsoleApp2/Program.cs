using System.Collections.Generic;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            var domains = new Dictionary<string, string>
            {
                {"PJK", "Püha Johannese Kool"},
                {"VG", "Viimsi Gümnaasium"},
                {"TTHK", "Tallinna Tööstusharidus Keskus"},
            };

            int i = 1;
            foreach (var pair in domains)
            {
                Console.WriteLine($"{pair.Value}");
                i++;
            }
        }
    }
}