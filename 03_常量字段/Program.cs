using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_常量字段
{
    //常量字段通常是编译的时候设置其值并且永远不会改变其值的字段。
    class Person
    {
        //常量
        public const int PETIREMENT_AGE = 60;//创建后不会改变
        public const int PETIREMENT_AGE_DELAY = PETIREMENT_AGE + 10;//赋值
        //变量
        string name;int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //常量可以直接使用，不需要使用new创建对象先
            Console.WriteLine("AGE={0},AGE_DELEY={1}", Person.PETIREMENT_AGE, Person.PETIREMENT_AGE_DELAY);

            Console.ReadKey();

        }
    }
}
