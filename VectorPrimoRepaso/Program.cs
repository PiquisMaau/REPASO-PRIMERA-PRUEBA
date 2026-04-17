using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace VectorPrimoRepaso
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dado un rangoInicial & rangoFinal
            //crear un Vector de los primos(métodos).
            //excepto aquellos que terminan en 1.
            Console.Write("Ingresa un rango inicial: ");
            int rangoInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa un rango final: ");
            int rangoFinal = Convert.ToInt32(Console.ReadLine()), contador = 0;

            int[] numeros = new int[rangoFinal - rangoInicial];
            int[] primos = new int[7];
            List<int> list = new List<int>();


            for (int i = rangoInicial; i <= rangoFinal ; i++)
            {
                //Console.WriteLine(NumeroPrimo(i));
                //if (NumeroPrimo(i)) contador++;
                SiEsUnoNo(i, list);
            }
            //Console.WriteLine(contador);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

        //private static Boolean NumeroPrimoV2(int numero)
        //{
        //    if (numero == 0 || numero == 1 || numero < 0)
        //    {
        //        return false;
        //    }
        //    if (numero % 2 == 0 && numero != 2)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i < numero - 1; i++)
        //    {
        //        if (numero % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public static Boolean NumeroPrimo(int numero)
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

        public static void SiEsUnoNo(int numero, List<int> list)
        {
            if (NumeroPrimo(numero) == true && numero%10 != 1)
            {
                list.Add(numero);
            }
           
        }
    }
}
