using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindbox
{
    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c, int x, int y, string name) : base(x, y, name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double area()
        {
            double perimetr = (a + b + c) / 2;
            return Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
        }
    }
}
