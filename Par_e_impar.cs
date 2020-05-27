using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("****Bienvenido**** \n Este es un programa que valida si el numero introducion es par o impar \n Introduzca un numero...");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero " + num + " es un numero par");
            }

            else
            {
                Console.WriteLine("El numero " + num + " es un numero impar");
            }

            Console.ReadKey();
        }
    }
}
