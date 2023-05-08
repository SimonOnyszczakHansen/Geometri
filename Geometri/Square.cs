using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square : Shapes
    {
        public Square(double a) 
        {
            this.a = a;
        }
        public override double GetPerimeter()
        {
            return a * 4;
        }
        public override double GetArea()
        {
            return Math.Pow(a, 2);
        }
        public override void Write()
        {
            Console.WriteLine($"Square: Areal: {GetArea()} Omkreds: {GetPerimeter()}\n");
        }
    }
}
