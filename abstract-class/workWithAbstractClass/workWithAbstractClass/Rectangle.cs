using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithAbstractClass
{
    internal class Rectangle : Figure
    {
        private double Side1 { get; set; }

        private double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override double Perimetr()
        {
            return (Side1 + Side2) * 2;
        }

        public override double Square()
        {
            return Side1 * Side2;
        }

        public override void Info()
        {
            Console.WriteLine($"  Прямоугольник\nСторона А = {Side1}\nСторона Б = {Side2}\nПериметр = {Perimetr()}\nПлощадь = {Square()}\n\n\n");
        }
    }
}
