using System;
using System.Globalization;

namespace mod01_exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a, b;
            a = Console.ReadLine().Split(" ");
            b = Console.ReadLine().Split(" ");
            if ((int.Parse(a[0]) <= int.Parse(b[0])
                && int.Parse(a[1]) <= int.Parse(b[1]))
                || (int.Parse(a[0]) <= int.Parse(b[1])
                && int.Parse(a[1]) <= int.Parse(b[0])))
            {
                Console.WriteLine("SIM");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NÃO");
                Console.ReadLine();
            }
        }
    }
}
