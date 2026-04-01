using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Ejercicio27Logica
    {
        private int[,] matrizDatos;

        public Ejercicio27Logica(int[,] matrizDatos)
        {
            this.matrizDatos = matrizDatos;
        }

        public void SucursalMayorInventario()
        {
            int mayorInventario = int.MinValue; 
            foreach (var item in matrizDatos)
            {
                if (item > mayorInventario)
                {
                    mayorInventario = item; 
                }
            }
            Console.WriteLine($"El item con mayor valor es: {mayorInventario}");
        }

        public void ProductoEscaso()
        {
            int productoEscaso = int.MaxValue;
            foreach (var item in matrizDatos)
            {
                if (item < productoEscaso)
                {
                    productoEscaso = item;
                }
            }
            Console.WriteLine($"El item con menor valor es: {productoEscaso}");
        }

        public void InventarioTotal()
        {
            int sumatoria = 0;
            foreach (var item in matrizDatos)
            {
                sumatoria += item;
            }
            Console.WriteLine($"El inventario total es: {sumatoria}");
        }
    }
}
