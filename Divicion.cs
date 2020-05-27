using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****Bienvenido**** \n Este es un programa de division con algunas condiciones");
         
            Console.WriteLine("Ingrese el primer numero");
            int numU = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int numD = Convert.ToInt32(Console.ReadLine());

            if (numD == 0)
            {
                Console.WriteLine("Error 404 no se puede dividir entre 0");
            }

            else
            {
                int resultado = numU / numD;
                Console.WriteLine("El resultado de la divicion de: " + numU + " / " + numD + " es " + resultado);   
            }

            Console.ReadKey();
        }
    }
}
