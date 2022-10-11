using System;

namespace TestMindbox
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius, int x, int y, string name) : base(x, y, name)
        {
            this.radius = radius;
        }

        public override double area()
        {
            return Math.PI * radius * radius;
        }
    }
}
