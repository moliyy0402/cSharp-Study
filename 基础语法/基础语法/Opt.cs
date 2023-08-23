using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 各种操作运算与java一致
 */
namespace 基础语法
{
    internal class Opt
    {
        public static void demo01()
        {
            int m = 1;
            int n;

            // a++ 先赋值再进行自增运算
            n = m++;
            Console.WriteLine("m = {0}", m);
            Console.WriteLine("n = {0}", n);



            int a = 60;            /* 60 = 0011 1100 */
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;

            c = a & b;           /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - c 的值是 {0}", c);

            c = a | b;           /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - c 的值是 {0}", c);

            c = a ^ b;           /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - c 的值是 {0}", c);

            c = ~a;               /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - c 的值是 {0}", c);

            c = a << 2;     /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            c = a >> 2;     /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - c 的值是 {0}", c);




            Type type = typeof(string);
            Console.WriteLine("type = {0}", type);


            //bool a = true, b = false, c = true;
            //bool result = a || b && c;  // 先计算与运算，再计算或运算
            //Console.WriteLine(result);  // 输出true

            //result = (a || b) && c;     // 先计算或运算，再计算与运算
            //Console.WriteLine(result);  // 输出true

            //result = a || (b && c);     // 先计算与运算，再计算或运算
            //Console.WriteLine(result);  // 输出true

            Console.ReadKey();
        }
    }
}

/*
其他运算符
下表列出了 C# 支持的其他一些重要的运算符，包括 sizeof、typeof 和 ? :。

运算符	描述	实例
sizeof()	返回数据类型的大小。	sizeof(int)，将返回 4.
typeof()	返回 class 的类型。	typeof(StreamReader);
&	返回变量的地址。	&a; 将得到变量的实际地址。
*	变量的指针。	*a; 将指向一个变量。
? :	条件表达式	如果条件为真 ? 则为 X : 否则为 Y
is	判断对象是否为某一类型。	If( Ford is Car) // 检查 Ford 是否是 Car 类的一个对象。
as	强制转换，即使转换失败也不会抛出异常。	Object obj = new StringReader("Hello");
StringReader r = obj as StringReader;
 */
