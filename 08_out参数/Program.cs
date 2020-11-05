using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_out参数
{
    class MyFunction
    {
        public static bool MyTryParse(string str,out int Number)
        {
            Number = -1;//如果转换失败返回0
            try
            {
                Number = Convert.ToInt32(str);//转换成数值类型
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "123a";
            if (MyFunction.MyTryParse(str, out int Number))
            {
                Console.WriteLine("转换成功！: {0}", Number);
            }
            else
            {
                Console.WriteLine(Number);
                Console.WriteLine("转换失败！请输入数字");
            }

            Console.ReadKey();

        }
    }
}
