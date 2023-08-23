using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    internal class 循环
    {
        public static void demo01()
        {
            int i = 0;
            while(i< 10)
            {
                Console.WriteLine("while i = {0}",i);
                i++;
            }

            Console.ReadKey();
        }


        public static void demo02() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for i = {0}", i);
            }

            Console.ReadKey();
        }

        public static void demo03()
        {
            int[] arr = {1,2,3,4,5,6,7,8,9 };
            foreach (int i in arr) {
                Console.WriteLine("foreach i = {0}", i);
            }


            Console.ReadKey();
        }

        public static void demo04()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i = 0;
            do {
                Console.WriteLine("do while i = {0}", i);
                i++;
            } while (i < 10);

            Console.ReadKey();
        }
    }
}
