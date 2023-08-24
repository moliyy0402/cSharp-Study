using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    internal class Func
    {
        public static int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }


        /// <summary>
        /// 递归求阶乘
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(num - 1) * num;
            }

        }

        /// <summary>
        /// 交换2个数的值
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void swap(int num1, int num2) {
            int temp = num1;

            num1 = num2;

            num2 = temp;


            Console.WriteLine("在交换之中，a 的值： {0}", num1);
            Console.WriteLine("在交换之中，b 的值： {0}", num2);

        }

        /// <summary>
        /// 交换两个数据的值
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void swap2(ref int num1,ref int num2)
        {
            int temp = num1;

            num1 = num2;

            num2 = temp;


            Console.WriteLine("在交换之中，a 的值： {0}", num1);
            Console.WriteLine("在交换之中，b 的值： {0}", num2);

        }

        /// <summary>
        /// 输出参数
        /// </summary>
        /// <param name="x"></param>
        public static void getValue(out int x)
        {
            x = 666;
        }

        /// <summary>
        /// 输出参数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void getValue(out int x,out int y)
        {
            x = 666;
            y = 999;
        }
    }
}
