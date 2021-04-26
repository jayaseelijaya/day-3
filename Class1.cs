using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Class1
    {
        void Sum(double a, double b)
        {
            Console.WriteLine("sum of a+b =" + (a + b));
        }
        void Sum(float a, float b)
        {
            Console.WriteLine("sum of a and b =" + (a + b));

        }
        void Sum(string a, string b)
        {
            Console.WriteLine("sum of string =" + (a + b));
        } 
        static void Main()
        {
            Class1 class1 = new Class1();
            class1.Sum(1,2);
            class1.Sum((1.4),(4.3));
            class1.Sum("jaya","seeli");
            Console.ReadLine();
        }

    }
}
