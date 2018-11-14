using System;

namespace mod01_exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inteiros;
            inteiros = Console.ReadLine().Split(" ");
            int soma = 0, a = int.Parse(inteiros[0]) ,
                b = int.Parse(inteiros[1]);
            while(a <= b)
            {
                if(a % 2 != 0)
                {
                    soma += a; 
                }
                a++;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
