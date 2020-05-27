using System;

namespace ConsoleAp
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n = 10;

                Console.WriteLine("****Bienvenido**** \n Este es un programa que pida al usuario un números enteros murtiplos de 10 \n Ingrese un numero muntiplo de 10");
                int nu = Convert.ToInt32(Console.ReadLine());

                if (nu % n == 0)
                {
                    Console.WriteLine(" El numero " + nu + " es murtiplo de 10");

                    Console.WriteLine(" ingrese el otro numero murtiplo de 10 ");
                    int nd = Convert.ToInt32(Console.ReadLine());

                if (nd % n == 0)
                {
                    Console.WriteLine(" El numero " + nd + " es murtiplo de 10");
                }

                else
                {
                    Console.WriteLine(" El numero " + nu + " no es murtiplo de 10");
                }

                }

                else
                {
                    Console.WriteLine(" El numero " + nu + " no es murtiplo de 10");
                }

               Console.ReadKey();

        }
    }
}
