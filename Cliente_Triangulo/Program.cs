using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasGeometricasBiclioteca;

namespace Cliente_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto();
            Punto p2 = new Punto();
            Punto p3 = new Punto();
            Triangulo triangulo2 = new Triangulo(p1,p2,p3);

            Triangulo triangulo = new Triangulo();
            //Datos de los puntos
            triangulo.x1 = 0;
            triangulo.y1 = 0;
            triangulo.x2 = 6;
            triangulo.y2 = 0;
            triangulo.x3 = 3;
            triangulo.y3 = 10;

            //Cálculo de lados
            triangulo.CalcularLdos();

            //Imprimimos lados
            Console.WriteLine(triangulo.ladoA);
            Console.WriteLine(triangulo.ladoB);
            Console.WriteLine(triangulo.ladoC);

            //VerificamoS si el triángulo 
            if (triangulo.VerificarTrianguloCorrecto())
            {
                Console.WriteLine("Es un triángulo correcto");
            }


        }
    }
}
