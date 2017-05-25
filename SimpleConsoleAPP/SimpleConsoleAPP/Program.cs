using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string myName =  Console.ReadLine();
            Console.WriteLine("Your name is {0}", myName);
        
            //OOP.
            // - Classes (java) look at C#
            Cars car = new Cars();
            Console.WriteLine("What is the model of your car.");
            car.Make = Console.ReadLine();
            Console.WriteLine("What is the make of your car.");
            car.Model = Console.ReadLine();
            Console.WriteLine("Which year was your car manufatured");
            car.YearOfManufacture = int.Parse(Console.ReadLine());

            car.PrintReport();

            Console.ReadLine();
        }
    }
}
