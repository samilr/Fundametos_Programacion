using System;

namespace parImpar
{
    class Program
    {
        public static void main (string[] args)

        {

            Console.WriteLine("******¡Bienvenido!******");
            Console.WriteLine("Este es un programa que verifica cual de los numeros introducidos es mayor \n Digite el primer numero...");
            int nu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int nd = Convert.ToInt32(Console.ReadLine());

            if (nu > nd)
            {
                Console.WriteLine("El numero " + nu + " es mayor que " + nd);
            }

            else

            if(nu < nd)
            {
                Console.WriteLine("El numero " + nd + " es mayor que " + nu);
            }

            else 
            {
                Console.WriteLine("Estos numeros son iguales"); 
            }

            Console.ReadKey();

        }
    }
}

