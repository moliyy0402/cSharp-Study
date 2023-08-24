using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    internal class Arrays
    {
        public static void demo01()
        {
            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */
            int i, j;


            /* 初始化数组 n 中的元素 */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* 输出每个数组元素的值 */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
        }

        public static void demo02()
        {

            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */
            /* 初始化数组 n 中的元素 */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            /* 输出每个数组元素的值 */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }



        public static void demo03()
        {
            /*
             C# 中二维数组的概念不同于 C/C++、java 等语言中的二维数组，C# 中的二维数组更像是一个矩阵：
             */

            int[,] arr = new int[3, 2] {
                {1,2 },
                {3,4 },
                {5,6 },
            };

            Console.WriteLine(arr[1, 0]);
            Console.WriteLine(arr[2, 1]);
            // arr.Length=总长度
            Console.WriteLine(arr.Length);

            // 要使用变量遍历必须使用数组的跌rand,也就是维度
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("i={0},j={1},arr[i,j]={2}", i, j, arr[i, j]);
                }
            }
        }

        public static void demo04()
        {
            int[,,] arr = {
                {
                    {1,2,3 },
                    {4,5,6 },
                    {7,8,9 },
                },
                {
                     {1,4,7 },
                    {2,5,8 },
                    {3,6,9 },
                },
                {
                     {9,8,7 },
                    {6,5,4 },
                    {3,2,1 },
                }
            };

            Console.WriteLine("arr Rank = {0}",arr.Rank);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < arr.GetLength(1); j++)
                {
                    for (global::System.Int32 k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine("arr[{0},{1},{2}]={3}", i, j, k, arr[i,j,k]);

                    }

                }

            }
        }

        public static void demo05()
        {
            int[][] arr = new int[2][] { new int[4] { 1, 2, 3, 4 }, new int[2] { 9, 8 } };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);

                Console.WriteLine("{0}", arr[i].Length);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("arr[{0}][{1}]={2}", i, j, arr[i][j]);
                }

            }

            Console.ReadKey();
        }


        public static void demo06(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }


            Console.WriteLine("sum={0}", sum);
        }
    }
}
