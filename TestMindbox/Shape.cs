using System;

namespace TestMindbox
{
    abstract class Shape
    {
        protected int x, y;
        protected string name;

        public Shape(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public abstract double area();
    }
}
