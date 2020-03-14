using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem1lab
{
    class Numbers
    {
        public void Number(double a, double b, string str)
        {
            while (str != "double")
            {
                Console.WriteLine("What type of numbers you want use? (double)");
                str = Console.ReadLine();
                if (str == "double")
                {
                    Console.WriteLine("Enter first number");
                    return a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("In the development...");
                    Console.Clear();
                }
            }     
        }
    }
}
