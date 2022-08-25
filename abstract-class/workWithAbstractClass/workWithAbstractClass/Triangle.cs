using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithAbstractClass
{
    internal class Triangle : Figure
    {

        private double A { get; set; }

        private double B { get; set; }

        private double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Perimetr()
        {
            return A + B + C;
        }

        public override double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override void Info()
        {
            Console.WriteLine($"  Tреугольник\nСторона А = {A}\nСторона Б = {B}\nСторона C = {C}\nПериметр = {Perimetr()}\nПлощадь = {Square()}");
        }

    }
}
