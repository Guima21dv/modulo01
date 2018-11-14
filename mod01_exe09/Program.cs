using System;
using System.Globalization;

namespace mod01_exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            double tmp_bateria, tmp_jogado;
            int num_jogatinas, i = 0;
            string saida = "";
            tmp_bateria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num_jogatinas = int.Parse(Console.ReadLine());
            while (i < num_jogatinas)
            {
                tmp_jogado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                tmp_bateria -= tmp_jogado;
                if (tmp_bateria > 0)
                {
                    saida += tmp_bateria.ToString("F1", CultureInfo.InvariantCulture) + "\n";
                    
                }
                else
                {
                    saida += "recarregar\n";
                }
                i++;
            }
            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
