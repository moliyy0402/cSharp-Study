using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 C# 类型转换
在 C# 中，类型转换是将一个数据类型的值转换为另一个数据类型的过程。
C# 中的类型转换可以分为两种：隐式类型转换和显式类型转换（也称为强制类型转换）。

 */
namespace 基础语法
{
    internal class DataTypeTrans
    {
        /*
         隐式类型转换
        隐式转换是指将一个较小范围的数据类型转换为较大范围的数据类型时，编译器会自动完成类型转换，
        这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。

        从小的整数类型转换为大的整数类型，从派生类转换为基类。
        将一个 byte 类型的变量赋值给 int 类型的变量，编译器会自动将 byte 类型转换为 int 类型，
        不需要显示转换。
         */
        public static void demo01() {
            byte b = 10;

            // 小类型转大类型 隐式转换
            int i = b;


            Console.WriteLine(i);

            int i1 = 456;

            // 隐式转换，从 int 到 long
            long l1 = i1;


            Console.WriteLine(l1);

        }


        public static void demo02() {
            int i = 10;

            // 显式转换，需要使用强制类型转换符号
            byte b = (byte)i;
            Console.WriteLine(b);

            double doubleValue = 3.14;
            // 强制从 double 到 int，数据可能损失小数部分
            int intValue = (int)doubleValue;
            Console.WriteLine(intValue);

            // 强制从 int 到 float，数据可能损失精度
            int i1 = 42;
            float floatValue = (float)i1;
            Console.WriteLine(floatValue);


            int i2 = 123;
            // 将 int 转换为字符串
            string stringValue = i2.ToString();

            Console.WriteLine(stringValue);


            object obj = 20;

            byte b1 = Convert.ToByte(obj);
            Console.WriteLine(b1);

            Console.ReadKey();
        }


        /*
         C# 类型转换方法
C# 提供了下列内置的类型转换方法：
        Convert类中
序号	方法 & 描述
1	ToBoolean
如果可能的话，把类型转换为布尔型。
2	ToByte
把类型转换为字节类型。
3	ToChar
如果可能的话，把类型转换为单个 Unicode 字符类型。
4	ToDateTime
把类型（整数或字符串类型）转换为 日期-时间 结构。
5	ToDecimal
把浮点型或整数类型转换为十进制类型。
6	ToDouble
把类型转换为双精度浮点型。
7	ToInt16
把类型转换为 16 位整数类型。
8	ToInt32
把类型转换为 32 位整数类型。
9	ToInt64
把类型转换为 64 位整数类型。
10	ToSbyte
把类型转换为有符号字节类型。
11	ToSingle
把类型转换为小浮点数类型。
12	ToString
把类型转换为字符串类型。
13	ToType
把类型转换为指定类型。
14	ToUInt16
把类型转换为 16 位无符号整数类型。
15	ToUInt32
把类型转换为 32 位无符号整数类型。
16	ToUInt64
把类型转换为 64 位无符号整数类型。
         */

    }
}
