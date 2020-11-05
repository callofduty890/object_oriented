using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_方法的参数列表
{
    class Point
    {
        public string X;
        public string Y;

        public Point(string str1, string str2)
        {
            this.X = str1;this.Y = str2;   
        }

    }

    class Test
    {
        public static void Swap(int x, int y)//两个数的交换 int x与int y称之为形参
        {
            int temp = x;x = y;y = temp;
        }
        public static void Swap(string x, string y)//交换了两个变量【函数的重载】
        {
            string temp = x; x = y; y = temp;
        }

        public void Swap(ref int x,ref int y)//引用地址传递
        {
            int temp = x; x = y; y = temp;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x=1, y=2; //实参
            //交换变量的值
            Test.Swap(x, y);
            Console.WriteLine("X:{0} Y:{1}", x, y);
            Console.WriteLine("============================");
            string X = "A";string Y = "B";
            Test.Swap(X, Y);
            Console.WriteLine("X:{0} Y:{1}", X, Y);
            Console.WriteLine("============================");
            Point p = new Point("A", "B");
            Test.Swap(p.X, p.Y);
            Console.WriteLine("p.X:{0} p.Y:{1}", p.X, p.Y);
            Console.WriteLine("============================");
            //使用Ref交换变量
            Test test = new Test();
            test.Swap(ref x, ref y);//进行变量就交换
            Console.WriteLine("x:{0} y:{1}", x, y);


            Console.ReadKey();

        }
    }
}
