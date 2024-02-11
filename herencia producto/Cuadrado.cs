using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_producto
{
    internal class Cuadrado:FiguraGeometrica
    {
        public double LadoA { get; set;}

        public double LadoB { get; set; }
        
        public override double CalcularArea()
        {
            return LadoA * LadoB;
        }

        public override double CalcularPerimetro()
        {
            return  2*LadoA*LadoB;
        }



    }
    
}
