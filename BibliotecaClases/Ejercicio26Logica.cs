using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Ejercicio26Logica
    {
        private double[,] Costos;


        public Ejercicio26Logica(double[,] costos)
        {
            this.Costos = costos;
        }

        public void MasCostosa()
        {
            //La más costosa
            double maximo = double.MinValue;

            foreach (double costo in Costos)
            {
                if (costo > maximo)
                {
                    maximo = costo;
                }
            }
            Console.WriteLine(maximo);
        }

        public void Promedio()
        {
            //promedio de costo
            double sumatoria = 0, promedio = 0;
            foreach (double costo in Costos)
            {
                sumatoria += costo;
            }
            promedio = sumatoria / Costos.LongLength;
            Console.WriteLine(promedio);
        }

        public void MenosCostoso()
        {
            //Menos costoso
            double minimo = double.MaxValue;

            foreach (double costo in Costos)
            {
                if (costo < minimo)
                {
                    minimo = costo;
                }
            }
            Console.WriteLine(minimo);
        }


    }
}
