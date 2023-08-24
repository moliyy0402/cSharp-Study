using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    // gitthu token: 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
    internal class Program
    {
        static void Main(string[] args)
        {
            // DataTypes.demo1();
            // DataTypes.demo2();

            // DataTypeTrans.demo02();

            // Constant.demo01();

            // Opt.demo01();

            // 循环.demo01();
            //循环.demo02();
            //循环.demo03();
            //循环.demo04();

            //Encapsulation1 e1 =  new Encapsulation1();
            //e1.length = 2.5;
            //e1.width = 1.5;
            //e1.Display();

            //Encapsulation2 e2 = new Encapsulation2();
            //e2.setVauleForKeys();
            //e2.Display();
            //Console.ReadKey();

            //int r = Func.FindMax(3, 4);
            //Console.WriteLine(r);

            //int n = 5;
            //Console.WriteLine("{0}的阶乘是：{1}", n, Func.Factorial(n));


            /* 局部变量定义 */
            //int a = 100;
            //int b = 200;

            //Console.WriteLine("在交换之前，a 的值： {0}", a);
            //Console.WriteLine("在交换之前，b 的值： {0}", b);

            ///* 调用函数来交换值 */
            //// Func.swap(a, b);

            //Func.swap2(ref a,ref b);

            //Console.WriteLine("在交换之后，a 的值： {0}", a);
            //Console.WriteLine("在交换之后，b 的值： {0}", b);




            /* 局部变量定义 */
            int a = 100;

            Console.WriteLine("在方法调用之前，a 的值： {0}", a);

            /* 调用函数来获取值 */
            Func.getValue(out a);

            Console.WriteLine("在方法调用之后，a 的值： {0}", a);



            /* 局部变量定义 */
            int q, w;

            /* 调用函数来获取值 */
            Func.getValue(out q, out w);

            Console.WriteLine("在方法调用之后，q 的值： {0}", q);
            Console.WriteLine("在方法调用之后，w 的值： {0}", w);
            Console.ReadKey();
        }
    }
}
