using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithAbstractClass
{
    internal class Triangle : Figure
    {
        private double Side1 { get; set; }

        private double Side2 { get; set; }

        private double Side3 { get; set; }

        public Triangle(double a, double b, double c)
        {
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }

        public override double Perimetr()
        {
            return Side1 + Side2 + Side3;
        }

        public override double Square()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public override void Info()
        {
            Console.WriteLine($"  Tреугольник\nСторона А = {Side1}\nСторона Б = {Side2}\nСторона C = {Side3}\nПериметр = {Perimetr()}\nПлощадь = {Square()}");
        }
    }
}
