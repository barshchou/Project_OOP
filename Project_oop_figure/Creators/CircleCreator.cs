using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_oop_figure.Figures;

namespace Project_oop_figure.Creators
{
    class CircleCreator : FigureCreator
    {
        public override Figure FactoryMethod()
        {
            return new Circle();
        }
    }
}
