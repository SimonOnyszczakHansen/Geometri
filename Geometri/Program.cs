using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(5);
            sq.Write();

            Parallelogram p = new Parallelogram(5, 6, 100);
            p.Write();

            Trapezoid tr = new Trapezoid(10, 9, 8, 9);
            tr.Write();

            Right_Angled_Triangle tri = new Right_Angled_Triangle(5, 6, 7);
            tri.Write();

            Rectangle rec = new Rectangle(5, 6);
            rec.Write();

            Console.Read();
        }
    }
}
