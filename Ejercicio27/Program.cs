using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    public class Program
    {
        static void Main(string[] args)
        {
            //            27.Control de inventario por sucursal
            //Enunciado:
            //Una cadena comercial registra en una matriz de 4x8 el número de unidades disponibles
            //de 8 productos en 4 sucursales.El programa debe determinar qué sucursal tiene mayor
            //inventario, qué producto está más escaso globalmente y el inventario total. 


            string ruta = "datosEJ27.csv";
            string[] lineas = File.ReadAllLines(ruta);

            int filas = lineas.Length;
            int columnas = lineas[0].Split(';').Length;
            int[,] matrizProductosSucursal = new int[filas, columnas];
            for (int f = 0; f < filas; f++)
            {
                string[] dato = lineas[f].Split(';');
                for (int c = 0; c < columnas; c++)
                {
                    matrizProductosSucursal[f, c] = Convert.ToInt32(dato[c]);
                }
            }
            Console.WriteLine("------ Mostrando .csv ------");
            ImprimirMatriz(matrizProductosSucursal);

            Console.WriteLine("------ Mostrando total de cada sucursal ------");
            int[] totalSucursal = TotalSucursal(matrizProductosSucursal);

            Console.WriteLine("------ Mostrando sucursal con mayor recaudacion ------");
            SucursalMayorInventario(totalSucursal);

            Console.WriteLine("------ Mostrando producto mas escaso ------");
            ProductoMasEscaso(matrizProductosSucursal);

            Console.WriteLine("----- Inventario Total ------");
            InventarioTotal(matrizProductosSucursal);

        }

        private static void InventarioTotal(int[,] matrizProductosSucursal)
        {
            int sumatoriaTotal = 0;
            for (int f = 0; f < matrizProductosSucursal.GetLength(0); f++)
            {
                for (int c = 0; c < matrizProductosSucursal.GetLength(1); c++)
                {
                    sumatoriaTotal += matrizProductosSucursal[f, c];
                }
            }
            Console.WriteLine($"El inventario total es: {sumatoriaTotal}");
        }

        private static void ProductoMasEscaso(int[,] matrizProductosSucursal)
        {
            int productoMenor = int.MaxValue, sucursal = 0, producto = 0, productoEscaso = int.MaxValue, contador = 0, posicionActual = 0, peoductoGanador = 0;
            int[] productoMasEscaso = new int[matrizProductosSucursal.GetLength(1)];
            for (int f = 0; f < matrizProductosSucursal.GetLength(0); f++)
            {
                for (int c = 0; c < matrizProductosSucursal.GetLength(1); c++)
                {
                    if (matrizProductosSucursal[f, c] < productoMenor)
                    {
                        productoMenor = matrizProductosSucursal[f, c];
                        producto = c + 1;
                        sucursal = f + 1;
                    }

                }
            }
            for (int c = 0; c < matrizProductosSucursal.GetLength(1); c++)
            {
                for (int f = 0; f < matrizProductosSucursal.GetLength(0); f++)
                {
                    productoMasEscaso[c] += matrizProductosSucursal[f, c];
                }
            }

            foreach (int item in productoMasEscaso)
            {
                posicionActual++;
                if (item < productoEscaso)
                {
                    productoEscaso = item;
                    contador = posicionActual;

                }
            }
            Console.WriteLine($"El producto más escaso es: {contador}. {productoEscaso}");
            Console.WriteLine($"El producto más escaso es: {producto}. {productoMenor} en la sucursal: {sucursal}");
        }

        private static void SucursalMayorInventario(int[] totalSucursal)
        {
            int numeroMayor = 0, indiceSucursaL = 0;
            for (int i = 0; i < totalSucursal.Length; i++)
            {
                if (totalSucursal[i] > numeroMayor)
                {
                    numeroMayor = totalSucursal[i];
                    indiceSucursaL = i + 1;
                }
            }
            Console.WriteLine($"La sucursal con más inventario es: {indiceSucursaL}. {numeroMayor}");
        }

        private static int[] TotalSucursal(int[,] matrizProductosSucursal)
        {
            int[] totalSucursal = new int[matrizProductosSucursal.GetLength(0)];
            for (int f = 0; f < matrizProductosSucursal.GetLength(0); f++)
            {
                for (int c = 0; c < matrizProductosSucursal.GetLength(1); c++)
                {
                    totalSucursal[f] += matrizProductosSucursal[f, c];
                }
                Console.Write(totalSucursal[f] + " ");
            }
            Console.WriteLine();
            return totalSucursal;
        }

        public static void ImprimirMatriz(int[,] o)
        {
            for(int f = 0; f < o.GetLength(0); f++)
            {
                for (int c = 0; c < o.GetLength(1); c++)
                {
                    Console.Write(o[f, c]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
