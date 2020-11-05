using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_代码
{
    class Dogs
    {
        //字段
        private string _name;
        private int _age;
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Dogs(int age)//非静态的构造函数
        {
            
              a= age;
        }
        static Dogs() //静态构造函数
        {
            a = 14;
        }

        public void SayHello() //非静态方法,需要实例化使用new
        {
            Console.WriteLine("{0} 汪汪汪！",this.Name);
        }
        static int a;//静态变量，启动exe程序就会分配空间。如果没有赋值采用默认值
        public static void Say() //静态方法,起到工具类的作用
        {
            Dogs objdog = new Dogs(12);
            Console.WriteLine("一只年纪为{0}的狗 Wow!Wow! ", objdog.Age);
        }
    }

    class Cat
    {
        //直接为对象分配属性
        public int Age { get; set; } //自动属性
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dogs dogs = new Dogs(2);
            dogs.Name = "旺柴";
            dogs.SayHello();//非静态的需要实例化
            Console.WriteLine("============================");
            //=============================
            Dogs.Say();//静态的方法直接使用
            Console.WriteLine("============================");
            //=============================
            Cat cat = new Cat() { Name = "Maomi", Age = 3 };//不同形式
            Console.WriteLine("{0}猫的年龄为: {1}", cat.Name, cat.Age);


            Console.ReadKey();//卡屏

        }
    }
}
