using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_oop_figure
{
    class Triangle : Figure
    {
        protected const double radius = 10;
        protected int x1, y1, x2, y2, x3, y3;
        protected double square;
        protected double perimeter;
        protected string name = "Triangle";
        protected string color = "Blue";

        public string Name
        {
            get { return this.name; } 
        }

        public string Color
        {
            get { return this.color; }
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public Triangle()
        {
        }

        public override double Square()
        {
            double a = Convert.ToDouble(Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            double b = Convert.ToDouble(Math.Sqrt((x3 - x2) ^ 2 + (y3 - y2) ^ 2));
            double c = Convert.ToDouble(Math.Sqrt((x1 - x3) ^ 2 + (y1 - y3) ^ 2));
            return square = 2 / a * Math.Sqrt(Perimeter() * (Perimeter() - a) * (Perimeter() - b) * (Perimeter() - c));
        }

        public override double Perimeter()
        {
            return perimeter = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2) + Math.Sqrt((x3 - x2) ^ 2 + (y3 - y2) ^ 2) + Math.Sqrt((x1 - x3) ^ 2 + (y1 - y3) ^ 2);
        }

        public override string ToString()
        {
            return "Figure: " + Name + " " + Color + " " + Square() + " " + Perimeter();
        }
    }
}
