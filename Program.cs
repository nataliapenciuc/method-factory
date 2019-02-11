using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a category of vehicle between 1 and 3");

            var budget = Console.ReadLine();
            var car = CarFactory.CreateCar(Convert.ToInt32(budget));

            Console.WriteLine($" You can get a {car.GetType().Name}");
            Console.Read();
        }
    }
}
