using System;

namespace pdis
{
    /*Crear un programa que multiplique dos números enteros de la siguiente forma:
    pedirá al usuario un primer número entero.Si el número que se que teclee es 0,
    escribirá en pantalla &quot;El producto de 0 por cualquier número es 0&quot;. Si se ha
    tecleado un número distinto de cero, se pedirá al usuario un segundo número y
    se mostrará el producto de ambos.*/
    class Program
    {
        static void Main(string[] args)
        {
            int secondNumber = 0;

            Console.WriteLine("****Bienvenido**** \n Este es un programa que multiplique dos números enteros. \n  Ingrese un numero entero");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == 0)
            {
                Console.WriteLine(" El producto de 0 por otro numero es 0  ");
                 
            }
            else
            {
                Console.WriteLine("Ingrese el 2do numero ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                int result = firstNumber * secondNumber;
                Console.WriteLine("EL RESULTADO DEL PRODUCTO DE LA MURTIPLICACION DE: " + firstNumber + "*" + secondNumber + " es: " + result);
            }
            Console.ReadKey();
        }
    }
}
