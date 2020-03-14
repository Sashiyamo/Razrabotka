using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem1lab
{
    class Menu
    {
        public void Menuing(int key, double a, double b, double c)
        {
            Operations Oper = new Operations(a, b, c);
            while (key != 5)
            {
                Console.Clear();
                Console.WriteLine("#######Operations#######");
                Console.WriteLine("1._________Sum__________");
                Console.WriteLine("2._________Sub__________");
                Console.WriteLine("3._________Mul__________");
                Console.WriteLine("4._________Div__________");
                Console.WriteLine("5._________Exit_________");

                Console.WriteLine("\n\n\nEnter number of operation\n");
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        Oper.Sum(a, b, c);
                        Console.WriteLine($"Answer: {a} + {b} = {c}");
                        Console.ReadLine();
                        break;
                    case 2:
                        Oper.Sub(a, b, c);
                        Console.WriteLine($"Answer: {a} - {b} = {c}");
                        Console.ReadLine();
                        break;
                    case 3:
                        Oper.Mul(a, b, c);
                        Console.WriteLine($"Answer: {a} * {b} = {c}");
                        Console.ReadLine();
                        break;
                    case 4:
                        Oper.Div(a, b, c);
                        Console.WriteLine($"Answer: {a} / {b} = {c}");
                        Console.ReadLine();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Incorrect key");
                        break;
                }
            }
            
        }

    }
}
