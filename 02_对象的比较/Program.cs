using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_对象的比较
{

    class Person
    {
        //字段
        private string _name;
        private int _age;
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        //构造函数
        public Person(string Name, int Age)
        {
            this.Name = Name;this.Age = Age;
        }
        //方法
        public void print()
        {
            Console.WriteLine("Name={0},age={1}", this.Name, this.Age);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person("教练", 25);
            Person personB = new Person("教练", 25);
            if (personA == personB) //比较对象
            {
                Console.WriteLine("personA与personB相同");
            }
            else
            {
                Console.WriteLine("personA与personB不相同");
            }
            personB = personA;
            if (personA == personB) //比较对象
            {
                Console.WriteLine("personA与personB相同");
            }
            else
            {
                Console.WriteLine("personA与personB不相同");
            }

            Console.ReadLine();

        }
    }
}
