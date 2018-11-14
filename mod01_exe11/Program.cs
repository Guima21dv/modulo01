using System;

namespace mod01_exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            string saida = "";
            int vol_inicial, comando_alteracao;
            vol_inicial = int.Parse(Console.ReadLine());
            comando_alteracao = int.Parse(Console.ReadLine());
            while (comando_alteracao != 0)
            {
                
                vol_inicial += comando_alteracao;
                if(vol_inicial > 100)
                {
                    vol_inicial = 100;
                }
                else if(vol_inicial < 0)
                {
                    vol_inicial = 0;
                }
                comando_alteracao = int.Parse(Console.ReadLine());
                saida += vol_inicial + "\n";
            };

            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
