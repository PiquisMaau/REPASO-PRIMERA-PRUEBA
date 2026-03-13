using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Repaso_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //@Gestor de Notas(Vectores y Matrices): Crea una matriz bidimensional de tamaño N filas(estudiantes)
            //y 3 columnas(calificaciones).Llena la matriz con valores aleatorios entre 0 y 10.Luego, crea un método
            //que reciba esta matriz como parámetro y devuelva un vector unidimensional que contenga el promedio exacto
            //de cada estudiante.

            Console.WriteLine("---------- Gestor de Notas -----------");
            Console.WriteLine("Ingresa el numero de estudiantes: ");
            int estudiantes = int.Parse(Console.ReadLine());
            for (int f = 0; f < CrearMatrizNotas(estudiantes).GetLength(0); f++)
            {
                for (int c = 0; c < CrearMatrizNotas(estudiantes).GetLength(1); c++)
                {
                    Console.Write(Math.Round(CrearMatrizNotas(estudiantes)[f, c]) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("El promedio de notas de cada estudiante es: ");
            foreach(double promedios in PromediosNotasEstudiantes(CrearMatrizNotas(estudiantes)))
            {
                Console.Write(Math.Round(promedios) + " ");
            }


        }

        static double[,] CrearMatrizNotas(int filas)
        {
            double[,] matrizNotas = new double[filas, 3];
            Random notasAleatorias = new Random();

            for (int f = 0; f<filas; f++)
            {
                for (int c = 0; c<3; c++)
                {
                    matrizNotas[f, c] = notasAleatorias.NextDouble() * 10;
                }
            }
            return matrizNotas;

        }

        static double[] PromediosNotasEstudiantes(double[,] notas){
            double[] promedios = new double[notas.GetLength(0)];

            for(int f =0; f < notas.GetLength(0); f++)
            {
                double sumatoria = 0;
                for(int c=0; c<notas.GetLength(1); c++)
                {
                    sumatoria += notas[f, c];
                }
                promedios[f] = sumatoria/ notas.GetLength(0);
            }

            return promedios;
        }
    }
}
