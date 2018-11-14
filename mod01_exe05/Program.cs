using System;
using System.Globalization;

namespace mod01_exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] distancias;
            distancias = Console.ReadLine().Split(" ");
            double a = double.Parse(distancias[0], CultureInfo.InvariantCulture),
                b = double.Parse(distancias[1], CultureInfo.InvariantCulture),
                c = double.Parse(distancias[2], CultureInfo.InvariantCulture);
            if(a > b)
            {
                if(a > c)
                {
                    Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
                    Console.ReadLine();
                }
            }else if(b > c)
            {
                Console.WriteLine(b.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
        }
    }
}
