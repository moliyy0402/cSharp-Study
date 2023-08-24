using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    internal class Nullable1
    {
        public static void demo01()
        {
            int? i = 1111;

            Console.WriteLine(i.ToString());

            Nullable<double> d = new Nullable<double>();
            Console.WriteLine(d.ToString());


            int? num1 = null;
            int? num2 = 67;
            Console.WriteLine(num2.ToString());
            double? num3 = new double();
            double? num4 = 3.1415926;

            // 注意加问号和不加问号的区别
            bool? b = new bool?();
            bool? b2 = new bool();

            // 显示值
            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}",
                            num1, num2, num3, num4);

            Console.WriteLine("一个可空的布尔值： {0},{1}", b,b2);
            Console.ReadKey();
        }

        public static void demo02()
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
            Console.WriteLine("num3 的值： {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("num3 的值： {0}", num3);
            Console.ReadLine();
        }
    }
}
