using System;
using System.Globalization;



namespace mod01_exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado;
            string[] notas = Console.ReadLine().Split(' ');
            resultado = float.Parse(notas[0], CultureInfo.InvariantCulture) + float.Parse(notas[1], CultureInfo.InvariantCulture) + float.Parse(notas[2], CultureInfo.InvariantCulture);
            if (resultado >= 60.00 )
            {
                Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("DEPENDÊNCIA!");
                Console.ReadLine();
            }
        }
    }
}
