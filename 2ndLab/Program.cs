using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_2
{
    class Program
    {
        static void Main(string[] args)


        {
            double length;
            double width;
            double area;
            double perimeter;

            do
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length:");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                width = Convert.ToDouble(Console.ReadLine());

                area = length * width;
                Console.WriteLine("Area:{0}", area);
                Console.ReadLine();

                perimeter = 2 * length + 2 * width;
                Console.WriteLine("Perimeter:{0}", perimeter);
                Console.ReadLine();




                Console.WriteLine("Continue?(y/n)");
                // Console.ReadLine();
            } while (Console.ReadLine() == "y");



        }
    }
}
