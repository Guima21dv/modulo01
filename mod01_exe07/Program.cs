using System;
using System.Globalization;

namespace mod01_exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string output = "";
            do
            {
                input = int.Parse(Console.ReadLine());
                if(input != 0)
                {
                    output += Math.Pow(input, 2) + "\n";
                }
            } while (input != 0);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
