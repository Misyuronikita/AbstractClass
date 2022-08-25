using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithAbstractClass
{
    internal class Circle : Figure
    {

        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Perimetr()
        {
            return Radius * 3.14 * 2;
        }

        public override double Square()
        {
            return Radius * Radius * 3.14;
        }

        public override void Info()
        {
            Console.WriteLine($"  Kруг\nPадиус = {Radius}\nПериметр = {Perimetr()}\nПлощадь = {Square()}\n\n\n");
        }

    }
}
