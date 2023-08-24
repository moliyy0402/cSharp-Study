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


            Encapsulation2 e2 = new Encapsulation2();
            e2.setVauleForKeys();

            e2.Display();

            Console.ReadKey();


        }
    }
}
