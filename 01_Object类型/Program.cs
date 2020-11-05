using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Object类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] obj = new object[3];
            obj[0] = 123; obj[1] = "abc";
            obj[2] = new DateTime(2020,11,5);

            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(
                    "object[{0}],{1},{2},{3}",
                    i,
                    obj[i],
                    (obj[i]).GetType(), 
                    (obj[i]).ToString()
                    );
            }
            Console.ReadKey();

        }
    }
}
