using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_oop_figure
{
    abstract class Figure
    {
        protected string name = "";
        protected string color = "";

        public abstract double Square();
        public abstract double Perimeter();
        
    }
}
