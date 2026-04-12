using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasBiclioteca
{
    public class Triangulo
    {
        public Triangulo()
        {
            
        }
        public Triangulo(Punto p1, Punto p2, Punto p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Punto P1 { get; set; }
        public Punto P2 { get; set; }
        public Punto P3 { get; set; }

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

        public void CalcularLdos()
        {
            ladoA = CalcularDistanciaEntreDosNumeros(x1, y1, x2, y2);
            ladoB = CalcularDistanciaEntreDosNumeros(x1, y1, x3, y3);
            ladoC = CalcularDistanciaEntreDosNumeros(x3, y3, x2, y2);

        }

        public bool VerificarTrianguloCorrecto()
        {
            if ((ladoA + ladoB) > ladoC && (ladoC + ladoB) > ladoA && (ladoA + ladoC) > ladoB)
                return true;
            else return false;
        }

        public double DevolverPerimetro()
        {
            double perimetro = ladoC + ladoB + ladoA;
            return perimetro;
        }

        public double DevolverSemiPerimetro()
        {
            double semiperimetro = (ladoC + ladoB + ladoA) / 2;
            //Tambien se puede hacer: DevolverPerimetro()/2;
            return semiperimetro;
        }

        public double CalcularAreaTriangulo()
        {
            return Math.Sqrt(DevolverSemiPerimetro() * (DevolverSemiPerimetro() - ladoA)
                * (DevolverSemiPerimetro() - ladoB) * (DevolverSemiPerimetro() - ladoC));
        }

        public string DevolverTipoTriangulo()
        {
            if (ladoA == ladoB && ladoB == ladoC)
                return "Equilatero";
            if (ladoA != ladoB && ladoB != ladoC)
                return "Escaleno";
            return "Isoceles";
        }

    }
}
