using System;
using System.Globalization;

namespace mod01_exe01
{
    class mod01_exe01
    {
        static void Main(string[] args)
        {
            int resultado, vol_veneno, vazao_bomba, tempo;
            vol_veneno = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vazao_bomba = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tempo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = vol_veneno - (vazao_bomba * tempo);
            if(resultado >= 0)
            {
                Console.WriteLine(resultado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não é possível!");
                Console.ReadLine();
            }
            
        }
    }
}
