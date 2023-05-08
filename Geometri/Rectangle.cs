using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Rectangle : Shapes
    {
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double GetPerimeter()
        {
            return 2 * (a + b);
        }
        public override double GetArea()
        {
            return a * b;
        }
        public override void Write()
        {
            Console.WriteLine($"Rektangel: Areal: {GetArea()} Omkreds: {GetPerimeter()}");
        }
    }
}
