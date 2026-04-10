using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasBiclioteca
{
    public class Triangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }

        public double y3 { get; set; }
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }


        private double CalcularDistanciaEntreDosNumeros(double CoorX1, double Coory1, double CoorX2, double Coory2)
        {
            return Math.Sqrt(Math.Pow((CoorX1 - CoorX2), 2) + Math.Pow((Coory1 - Coory2), 2));
        }

        void CalcularLdos()
        {
            ladoA = CalcularDistanciaEntreDosNumeros(x1, y1, x2, y2);
            ladoB = CalcularDistanciaEntreDosNumeros(x1, y1, x3, y3);           
            ladoC = CalcularDistanciaEntreDosNumeros(x3, y3, x2, y2);

        }

    }
}
