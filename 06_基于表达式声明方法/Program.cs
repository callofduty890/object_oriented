using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_基于表达式声明方法
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
        => Number1 + Number2;
       
        //求某个数的平方
        public int SquareANumber(int Number)
        => Number * Number;
       

        //静态的方法
        public static void DisplayResult(int Number)//显示结果
        =>Console.WriteLine("结果为:{0}", Number);


    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
