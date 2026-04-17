using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBancarioRepaso
{
    public class USUARIO
    {
        

        public string ID_Usuario { get; set; }
        public string  Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calve{ get; set; }
        public Decimal MontoCuenta{ get; set; }

        public USUARIO()
        {
            
        }
        public USUARIO(string iD_Usuario, string usuario, string nombre, string apellido, string calve, decimal montoCuenta)
        {
            ID_Usuario = iD_Usuario;
            Usuario = usuario;
            Nombre = nombre;
            Apellido = apellido;
            Calve = calve;
            MontoCuenta = montoCuenta;
        }
    }
}
