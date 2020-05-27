using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Bienvenido**** \n Este es un programa que verifica si los numeros son murtiplos de 4 o de 5");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 4 == 0)
            {
                if (num % 5 == 0)
                {
                    Console.WriteLine("El numero " + num + " es murtiplo de 4 o 5");
                }
                
            }
                

            else
                {
                    Console.WriteLine("El numero " + num + " no es murtiplo de 4 o 5");
                }

                Console.ReadKey();
            }
        }
    }
