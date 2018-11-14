using System;
using System.Globalization;

namespace mod01_exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtde_glicose;
            qtde_glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(qtde_glicose <= 100.0)
            {
                Console.WriteLine("Normal");
                Console.ReadLine();
            }else if(qtde_glicose > 100.0 && qtde_glicose <= 140.0)
            {
                Console.WriteLine("Elevado");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Diabetes");
                Console.ReadLine();
            }
            
        }
    }
}
