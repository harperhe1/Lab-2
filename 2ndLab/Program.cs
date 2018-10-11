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
            double height;
            double area;
            double perimeter;
            double volume;
            string yesOrNo;
            bool cont = true;


            do
            {
                
                bool cont2 = true;

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length:");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Height:");
                height = Convert.ToDouble(Console.ReadLine());

                area = length * width;
                Console.WriteLine("Area:{0}", area);                

                perimeter = 2 * length + 2 * width;
                Console.WriteLine("Perimeter:{0}", perimeter);                

                volume = length * width * height;
                Console.WriteLine("Volume:{0}", volume);             


                Console.WriteLine("Continue?(y/n)");
                while (cont2) // cont2 is true
                {

                    yesOrNo = Console.ReadLine().ToLower();

                    if (yesOrNo == "y")
                    {
                        cont2 = false; // exit while loop
                    }
                    else if (yesOrNo == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont = false; //exit do while loop
                        cont2 = false; // while loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try Again");
                    }
                }
                // Console.ReadLine();
            } while (cont);

            


        }
    }
}
