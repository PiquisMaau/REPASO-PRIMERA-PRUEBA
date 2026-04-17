using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MatricesRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int filas = random.Next(1, 10);
            int columnas = random.Next(1, 10);
            double[] precios = new double[filas];
            Console.Write("Precios: ");
            for (int i = 0; i < precios.Length; i++)
            {
                precios[i] = 10000 + (random.NextDouble() * 30000);
                precios[i] = Math.Round(precios[i], 2);
                Console.Write(precios[i] + " | ");
            }
            Console.WriteLine();




            //Cargar matriz con numeros random
            int[,] vehiculosVentas = CargarMatrizRandom(random, filas, columnas);
            //Imprimir matriz
            ImprimirMatriz(filas, columnas, vehiculosVentas);

            //Cuantos vehiculos se vendieron
            VehiculosVendidos(vehiculosVentas);

            //Cuánto se recaudó
            TotalRecaudo(precios, vehiculosVentas);

            //Cual fue el mejor año de ventas
            YearMejoresVentas(columnas, vehiculosVentas);

            //Cual posicion de vehiculos dio mejores reditos al negocio?
            ReditoMayor(columnas, precios, vehiculosVentas);

            //Porcentaje de ingresos por año
            PocentajerPerYear(columnas, precios, vehiculosVentas);

            //Diferencias entre años pares e impares
            DiferenciaYearsParesImpares(precios, vehiculosVentas);

        }

        private static void DiferenciaYearsParesImpares(double[] precios, int[,] vehiculosVentas)
        {
            double sumatoriaPares = 0, sumatoriaImpares = 0;
            Console.WriteLine();
            for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
            {
                for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
                {
                    if ((c + 1) % 2 == 0)
                    {
                        sumatoriaPares += vehiculosVentas[f, c] * precios[f];
                    }
                    else sumatoriaImpares += vehiculosVentas[f, c] * precios[f];
                }
            }
            Console.WriteLine("La diferencia entre años pares e impares es: " + Math.Abs(sumatoriaImpares - sumatoriaPares));
        }

        private static void PocentajerPerYear(int columnas, double[] precios, int[,] vehiculosVentas)
        {
            double recaudo = 0;
            double[] recaudos = new double[columnas];
            for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
            {
                for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
                {
                    recaudo += vehiculosVentas[f, c] * precios[f];
                }
            }
            for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
            {
                for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
                {
                    recaudos[c] += vehiculosVentas[f, c] * precios[f];
                }
            }
            double[] porcentajesRecaudos = new double[columnas];
            Console.Write("Porcentajes por año: ");
            for (int i = 0; i < recaudos.Length; i++)
            {
                porcentajesRecaudos[i] = (recaudos[i] * 100) / recaudo;
                Console.Write((1 + i) + ". " + Math.Round(porcentajesRecaudos[i], 2) + " ");
            }
        }

        private static void ReditoMayor(int columnas, double[] precios, int[,] vehiculosVentas)
        {
            int[] reditos = new int[columnas];

            for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
            {
                for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
                {
                    reditos[c] += vehiculosVentas[f, c];
                }
            }
            int reditoMayor = int.MinValue;
            int contador = 1;
            double reditoMayorPrecio = 1;
            for (int i = 0; i < reditos.Length; i++)
            {
                if (reditos[i] > reditoMayor)
                {
                    reditoMayor = reditos[i];
                    contador++;
                }
            }
            for (int i = 0; i < precios.Length; i++)
            {
                if (contador - 1 == i)
                {
                    reditoMayorPrecio = reditoMayor * precios[i];
                }
            }
            Console.WriteLine($"El modelo de carros con mejores reditos fue: {contador}. {reditoMayor} ({reditoMayorPrecio})");
        }

        private static void YearMejoresVentas(int columnas, int[,] vehiculosVentas)
        {
            double[] YearVentas = new double[columnas];
            for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
            {
                for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
                {
                    YearVentas[c] += vehiculosVentas[f, c];
                }
            }
            double YearMayor = double.MinValue;
            int contador = 1;
            for (int i = 0; i < YearVentas.Length; i++)
            {
                if (YearVentas[i] > YearMayor)
                {
                    YearMayor = YearVentas[i];
                    contador++;
                }
            }
            Console.WriteLine($"El año con las mejores ventas fue: {contador}. {YearMayor}");
        }

        private static void TotalRecaudo(double[] precios, int[,] vehiculosVentas)
        {
            double recaudo = 0;
            for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
            {
                for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
                {
                    recaudo += vehiculosVentas[f, c] * precios[f];
                }
            }
            Console.WriteLine("El recaudo fué: " + recaudo);
        }

        private static void VehiculosVendidos(int[,] vehiculosVentas)
        {
            int sumatoria = 0;
            for (int f = 0; f < vehiculosVentas.GetLength(0); f++)
            {
                for (int c = 0; c < vehiculosVentas.GetLength(1); c++)
                {
                    sumatoria += vehiculosVentas[f, c];
                }
            }
            Console.WriteLine("La cantidad de vehiculos vendidos es: " + sumatoria);

        }

        private static void ImprimirMatriz(int filas, int columnas, int[,] vehiculosVentas)
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(vehiculosVentas[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] CargarMatrizRandom(Random random, int filas, int columnas)
        {
            int[,] vehiculosVentas = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    vehiculosVentas[f, c] = random.Next(1, 30);
                }
            }

            return vehiculosVentas;
        }
    }
}
