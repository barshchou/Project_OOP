using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_oop_figure
{
    class Circle : Figure
    {
        protected double radius;
        protected int x1, y1;
        protected double square;
        protected double perimeter;
        protected string name = "Circle";
        protected string color = "Red";

        public string Name
        {
            get { return this.name; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public Circle(int x1, int y1, double radius)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.radius = radius;
        }

        public override double Square()
        {
            return square = Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
           return perimeter = 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return "Figure: " + Name + " " + Color + " " + Square() + " " + Perimeter();
        }
    }
}
