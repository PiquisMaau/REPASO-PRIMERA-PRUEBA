using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBancarioRepaso
{
     public class DatosArchivoCSV
    {
        public List<USUARIO> usuarios = new List<USUARIO>();

        string url = "USUARIOSBANCO.txt";

        string[] lineas; 
            public DatosArchivoCSV()
        {
            
            if (File.Exists(url))
            {
                lineas = File.ReadAllLines(url);
            }
            else
            {
                Console.WriteLine("El archivo CSV no existe en la ruta especificada.");
            }
            LeerArchivoCSV();
        }
        public void LeerArchivoCSV()
        {
            lineas = File.ReadAllLines(url);
            for (int i = 1; i < lineas.Length; i++) //Nos saltamos el encabezado
            {
                string[] dato = lineas[i].Split(';');
                USUARIO nuevoUsuario = new USUARIO();
                nuevoUsuario.ID_Usuario = dato[0];
                nuevoUsuario.Usuario = dato[1];
                nuevoUsuario.Nombre = dato[2];
                nuevoUsuario.Apellido = dato[3];
                nuevoUsuario.Calve = dato[4];
                nuevoUsuario.MontoCuenta = Convert.ToDecimal(dato[5]);

                usuarios.Add(nuevoUsuario);
            }
        }


    }
}
