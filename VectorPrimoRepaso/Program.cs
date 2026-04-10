using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace VectorPrimoRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dado un rangoInicial & rangoFinal
            //crear me Vector de los primos(métodos).
            //excepto aquellos que terminan en 1.

            int rangoInicial = Convert.ToInt32(Console.ReadLine());
            int rangoFinal = Convert.ToInt32(Console.ReadLine()), contador = 0;

            int[] numeros = new int[rangoFinal - rangoInicial];
            int[] primos = new int[7];


            for (int i = rangoInicial; i < rangoFinal; i++)
            {
                
            }

        }

        Boolean NumeroPrimo(int numero)
        {
            if (numero== 0 || numero == 1 || numero <0)
            {
                return false;
            }
            if (numero % 2 == 0 && numero != 2)
            {
                return false;
            }
            
            for (int i = 2; i < numero - 1; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
