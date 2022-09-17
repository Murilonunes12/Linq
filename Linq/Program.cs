using System;
using System.Linq;

namespace Linq
{
    class Resolucao
    {
        static void Main(string[] args)
        {
            int[] numero = new int[11];
            
            Console.WriteLine("Informe os números:");
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Numeros[" + i + "] :");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
             
            int numimpar = (from n in numero select n).Where(n => n % 2 > 0).Count();

            Console.WriteLine($"De todos os apresentados possui {numimpar} '+' impares presentes");
            Console.ReadLine();
        }
    }
}