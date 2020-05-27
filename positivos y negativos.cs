using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numd;

            Console.WriteLine("****Bienvenido**** \n Este es un programa que valida si un numero es positivo \n Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            numd = Convert.ToInt32(Console.ReadLine());


            if ((num >= 0) && (numd >= 0)) 
            { 
                Console.WriteLine("Ambos numeros son positivos");
            }

            if ((num < 0) && (numd >= 0))
            {
                Console.WriteLine("Solo un numero es positivo");
            }

            if ((num >= 0) && (numd < 0))
            {
                Console.WriteLine("Solo un numero es positivo");
            }

            if ((num < 0) && (numd < 0))
            {
                Console.WriteLine("Negativos");
            }

            Console.ReadKey();
        }
    }
}
