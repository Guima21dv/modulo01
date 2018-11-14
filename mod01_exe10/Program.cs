using System;
using System.Globalization;

namespace mod01_exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde_alunos;
            string[] notas;
            string saida = "";
            double total;
            qtde_alunos = int.Parse(Console.ReadLine());
            for(int i = 0;i < qtde_alunos; i++)
            {
                notas = Console.ReadLine().Split(" ");
                total = double.Parse(notas[0], CultureInfo.InvariantCulture) +
                    double.Parse(notas[1], CultureInfo.InvariantCulture) +
                    double.Parse(notas[2], CultureInfo.InvariantCulture);
                saida += total.ToString("F2", CultureInfo.InvariantCulture) + "\n";
            }
            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
