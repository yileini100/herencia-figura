using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_producto
{
    internal class Circulo:FiguraGeometrica
    {
        public double radio { get; set;}

        public override double CalcularArea()
        {
            return 3.14 * radio * 2;
        }

        public override double CalcularPerimetro()
        {
            return  2 *  3.14 * radio;
        }



    }
    
}
