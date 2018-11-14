using System;

namespace mod01_exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            while (a <= b)
            {
                if (a % n == 0) {

                    Console.WriteLine(a);
                }
                a++;
            }
            Console.ReadLine();
        }
    }
}
