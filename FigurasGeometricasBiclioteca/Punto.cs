using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasBiclioteca
{
    public class Punto
    {
        public double x { get; set; }
        public double y { get; set; }

        public Punto()
        {
            
        }

        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
