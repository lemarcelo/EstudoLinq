using System.Linq;
using System;

namespace PrimeiroLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {1, 2,7,8, 3, 4, 5, 6, 9, 10};
            //"select campo from tabela"
            var resultado = from num in numeros
                            orderby num
                            where num > 4
                            select num;
            var resultado2 = numeros.Where(n => n > 4).OrderBy(x => x);
            foreach (int numero in resultado2)
            {
                    Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
