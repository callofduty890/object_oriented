using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_只读字段
{
    class ReadOnlyField
    {
        public int x;
        public readonly int y = 2;//声明并初始化只读字段
        public readonly int z;      //声明只读字段

        public ReadOnlyField() //默认的构造函数
        {
            z = 3;//初始化只读字段
        }

        public ReadOnlyField(int p1,int p2,int p3) //默认的构造函数
        {
            x = p1;y = p2;z = p3;//分别赋值
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyField p1 = new ReadOnlyField();//默认构造函数
            p1.x = 1;
            //p1.z = 33;//编译错误，这个是只读字段
            Console.WriteLine("p1:x={0},y={1},z={2}", p1.x, p1.y, p1.z);

            //有参的构造函数
            ReadOnlyField p2 = new ReadOnlyField(11,22,33);
            Console.WriteLine("p1:x={0},y={1},z={2}", p2.x, p2.y, p2.z);

            Console.ReadKey();

        }
    }
}
