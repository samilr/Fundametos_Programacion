using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int numU, numD, numT, mayor;

            Console.Write("Ingrese el primer numero:");
            numU = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero:");
            numD = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer numero:");
            numT = Convert.ToInt32(Console.ReadLine());

            if ((numU > numD) && (numU > numT))
            {
                mayor = numU;
            }

           else if ((numD > numU) && (numD > numT))
            {
                mayor = numD;
            }
               

            else
            {
                mayor = numT;
            }
            Console.WriteLine(mayor);

            Console.ReadKey();
        

      }
    }
}
