using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******¡Bienvenido!******");
            Console.WriteLine("Este es un programa que verifica si el primer numero es murtiplo del segundo \n Digite el primer numero...");
            int nu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int nd = Convert.ToInt32(Console.ReadLine());

            if (nu % nd == 0)
            {
                Console.WriteLine("El numero " + nu + " es murtiplo de " + nd);
            }

            else
            {
                Console.WriteLine("El numero " + nu + " no es murtiplo de " + nd);
            }

            Console.ReadKey();

        }
    }
}