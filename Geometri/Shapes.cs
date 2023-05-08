using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public abstract class Shapes
    {
        protected double a;
        public double A
        {
            get { return a; } 
            set { a = value; }
        }
        public abstract double GetPerimeter();
        public abstract double GetArea();
        public abstract void Write();
    }
}
