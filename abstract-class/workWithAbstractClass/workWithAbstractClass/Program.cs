using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figure = new Figure[]
            {
                new Circle(3),
                new Rectangle(2,4),
                new Triangle(3,3,3)
            };
            
            foreach (var item in figure) {

                item.Info();
            }

            Console.ReadKey();
        }
    }
}
