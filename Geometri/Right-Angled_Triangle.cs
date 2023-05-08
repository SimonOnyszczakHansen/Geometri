using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Right_Angled_Triangle : Shapes
    {
        private double b;
        private double c;

        public Right_Angled_Triangle(double a,  double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetPerimeter()
        {
            return a + b + c;
        }
        public override double GetArea()
        {
            return 0.5 * a * b;
        }
        public override void Write()
        {
            Console.WriteLine($"Retvinket trekant: Areal: {GetArea()} Omkreds: {GetPerimeter()}\n");
        }
    }
}
