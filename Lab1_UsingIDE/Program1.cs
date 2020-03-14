using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem1lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            string str = "";
            int key = 0;

            Numbers Number1 = new Numbers();
            Number1.Number(a, b, str);

            Menu Menu1 = new Menu();
            Menu1.Menuing(key, a, b, c);
        }
    }
}
