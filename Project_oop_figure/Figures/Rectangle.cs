using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_oop_figure
{
    class Rectangle : Figure
    {
        protected const double radius = 10;
        protected int x1, y1, x2, y2, x3, y3, x4, y4;
        protected double square;
        protected double perimeter;
        protected string name = "Rectangle";
        protected string color = "Green";

        public string Name
        {
            get { return this.name; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override double Perimeter()
        {
            return perimeter = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2) * 2 + Math.Sqrt((x3 - x2) ^ 2 + (y3 - y2) ^ 2) * 2;
        }

        public override double Square()
        {
           return square = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2) * Math.Sqrt((x3 - x2) ^ 2 + (y3 - y2) ^ 2);
        }
    }
}
