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
            
        }
    }
}
