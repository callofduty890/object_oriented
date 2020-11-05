using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_可选参数
{
    class Program
    {
        static  void Display(int a, double b = 2, int c = 6)
        {
            Console.WriteLine("调用有三个参数的方法");
            Console.WriteLine("a={0},b={1},c={2}", a, b, c);
        }

        static void Main(string[] args)
        {
            Display(1);
            Console.WriteLine("===========================");
            Display(1,2);
            Console.WriteLine("===========================");
            Display(1,2,3);
            Console.WriteLine("===========================");

            Console.ReadKey();
        }
    }
}
