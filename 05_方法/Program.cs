using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_方法
{
    class SimpleMath //数学计算的类
    {
        /// <summary>
        /// 两个数相加的和
        /// </summary>
        /// <param name="Number1">加数</param>
        /// <param name="Number2">被加数</param>
        /// <returns>和</returns>
        public int AddTwoNumbers(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        //求某个数的平方
        public int SquareANumber(int Number)
        {
            return Number * Number;
        }

        //静态的方法
        public static void DisplayResult(int Number)//显示结果
        {
            Console.WriteLine("结果为:{0}", Number);
        }

    }

    class Program
    {
        //Main称之为主入口函数，每一个程序只有一个主入口函数
        static void Main(string[] args)
        {
            SimpleMath ObjsimpleMath = new SimpleMath();
            //拿到运算结果并返回值
            int result= ObjsimpleMath.AddTwoNumbers(1, 2);
            SimpleMath.DisplayResult(result);

            //求某个数的平方
            SimpleMath.DisplayResult(ObjsimpleMath.SquareANumber(2));

            Console.ReadKey();

        }
    }
}
