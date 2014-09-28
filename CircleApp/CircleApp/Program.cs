using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle =new Circle();

            aCircle.radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("the diamitter is "+  aCircle.GatDiamitter());
            Console.WriteLine("the perimeter is " + aCircle.parimiter());
            Console.WriteLine("the diamitter is " + aCircle.GetArea());
            Console.ReadKey();
        }
    }
}
