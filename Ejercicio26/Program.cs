using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Ejercicio26
{
    public class Program
    {
        static void Main(string[] args)
        {
            //            26.Matriz de costos de transporte
            //Enunciado:
            //Una compañía registra en una matriz de 5x5 los costos de transporte entre cinco
            //ciudades.Desarrolla un programa que identifique la ruta más costosa, la menos costosa y
            //el costo promedio de todas las rutas registradas. 

            Console.WriteLine("-------- Costos de transporte --------");
            Random random = new Random();
            double[,] costos = new double[5, 5];
            for (int f = 0; f < costos.GetLength(0); f++)
            {
                for (int c = 0; c < costos.GetLength(1); c++)
                {
                    costos[f, c] = Math.Round(random.NextDouble() * (50 - 5) + 5, 2);
                    Console.Write(costos[f,c] + " ");
                }
                Console.WriteLine();
            }

            Ejercicio26Logica ej1 = new Ejercicio26Logica(costos);
            ej1.MasCostosa();
            ej1.MenosCostoso();
            ej1.Promedio();



        }
    }
}
