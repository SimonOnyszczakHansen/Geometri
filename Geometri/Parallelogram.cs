using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Parallelogram : Shapes
    {
        private double width;
        private double angle;
        public Parallelogram(double a, double width, double angle) 
        {
            this.a = a; 
            this.width = width;
            this.angle = angle;
        }
        public override double GetPerimeter()
        {
            return 2 * a + 2 * width;
        }
        public override double GetArea()
        {
            double d = Math.PI - (angle * (Math.PI / 180));
            return a * width * Math.Sin(d);
        }
        public override void Write()
        {
            Console.WriteLine($"Parallelogram: Areal: {GetArea()} Omkreds: {GetPerimeter()}\n");
        }
    }
}
