using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Trapezoid : Shapes
    {
        private double b;
        private double c;
        private double d;
        public Trapezoid(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override double GetArea()
        {
            double s = a + b - c + d / 2;
            double h = 2 / a - c * Math.Sqrt(s * (s - a + c) * (s - b) * (s - d));
            return 0.5 * (a + c) * h;
        }
        public override double GetPerimeter()
        {
            return a + b + c + d;
        }
        public override void Write()
        {
            Console.WriteLine($"Trapez: Areal: {GetArea()} Omkreds: {GetPerimeter()}\n");
        }
    }
}
