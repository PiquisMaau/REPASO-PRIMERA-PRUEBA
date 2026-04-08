using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Usuario
    {
        public Usuario(int iD_Usuario, string nombre, string apellido)
        {
            ID_Usuario = iD_Usuario;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
