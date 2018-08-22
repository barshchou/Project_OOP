using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_oop_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Circle(1, 1, 5);
            
            Console.WriteLine(figure.ToString());

            Console.ReadKey();
        }
    }
}
