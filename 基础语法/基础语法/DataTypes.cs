using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/**
 * 数据类型：
 *      值类型：
 *          值类型变量可以直接分配给一个值。它们是从类 System.ValueType 中派生的
 *          值类型直接包含数据。比如 int、char、float，它们分别存储数字、字符、浮点数。当您声明一个 int 类型时，系统分配内存来存储值。
 *          bool：true/false                                       1字节=8位      default: false
 *          byte：无符号整数：0-255                                1字节=8位      default: 0
 *          sbyte：有符号整数：-128-127                            1字节=8位      default: 0
 *          char：Unicode 字符：U +0000 到 U +ffff                 2字节=16位     default: '\0'
 *          short：有符号整数:-32768(-2^8) 到 32767(2^8-1)         2字节=16位     default: 0
 *          

类型	描述	范围	默认值
bool	布尔值	True 或 False	False
byte	8 位无符号整数	0 到 255	0
char	16 位 Unicode 字符	U +0000 到 U +ffff	'\0'
decimal	128 位精确的十进制值，28-29 有效位数	(-7.9 x 1028 到 7.9 x 1028) / 100 到 28	0.0M
double	64 位双精度浮点型	(+/-)5.0 x 10-324 到 (+/-)1.7 x 10308	0.0D
float	32 位单精度浮点型	-3.4 x 1038 到 + 3.4 x 1038	0.0F
int	32 位有符号整数类型	-2,147,483,648 到 2,147,483,647	0
long	64 位有符号整数类型	-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807	0L
sbyte	8 位有符号整数类型	-128 到 127	0
short	16 位有符号整数类型	-32,768 到 32,767	0
uint	32 位无符号整数类型	0 到 4,294,967,295	0
ulong	64 位无符号整数类型	0 到 18,446,744,073,709,551,615	0
ushort	16 位无符号整数类型	0 到 65,535	0


注意事项：
    基本数据类型有：整数有8种，浮点数有3种，布尔数1种，字符1种，共13种
    c#中整数分为有符号和无符号，byte默认是无符号，short、int、long是有符号
 */
namespace 基础语法
{
    internal class DataTypes
    {

        /// <summary>
        /// 值数据类型
        /// </summary>
        public static void demo1()
        {
            bool flag = true;
            Console.WriteLine("boll:flag={0}", flag);

            byte a1 = 255;
            // 编译错误
            //a1 = -1;
            //a1 = -128;
            //a1 = 256;
            Console.WriteLine("byte:a1={0}", a1);
            sbyte a2 = 127;
            a2 = -1;
            // 编译错误
            // a2 = 128;
            //a2 = 256;
            Console.WriteLine("byte:a2={0}", a2);


            int a3 = 345;
            Console.WriteLine("byte:a3={0}", a3);


            /*
            * 如需得到一个类型或一个变量在特定平台上的准确尺寸，可以使用 sizeof 方法。
            * 表达式 sizeof(type) 产生以字节为单位存储对象或类型的存储尺寸。下面举例获取任何机器上 int 类型的存储尺寸：
            */
            Console.WriteLine("Size of bool:{0}", sizeof(bool));
            Console.WriteLine("Size of char:{0}", sizeof(char));
            Console.WriteLine("Size of byte:{0}", sizeof(byte));
            Console.WriteLine("Size of sbyte:{0}", sizeof(sbyte));
            Console.WriteLine("Size of short:{0}", sizeof(short));
            Console.WriteLine("Size of ushort:{0}", sizeof(ushort));
            Console.WriteLine("Size of int:{0}", sizeof(int));
            Console.WriteLine("Size of uint:{0}", sizeof(uint));
            Console.WriteLine("Size of long:{0}", sizeof(long));
            Console.WriteLine("Size of ulong:{0}", sizeof(ulong));
            Console.WriteLine("Size of float:{0}", sizeof(float));
            Console.WriteLine("Size of double:{0}", sizeof(double));
            Console.WriteLine("Size of decimal:{0}", sizeof(decimal));

            Console.ReadKey();
        }



        /// <summary>
        /// 引用数据类型（Reference types）
        /// 引用类型不包含存储在变量中的实际数据，但它们包含对变量的引用。
        /// 换句话说，它们指的是一个内存位置。使用多个变量时，引用类型可以指向一个内存位置。
        /// 如果内存位置的数据是由一个变量改变的，其他变量会自动反映这种值的变化。
        /// 内置的 引用类型有：object、dynamic 和 string。
        /// </summary>
        public static void demo2()
        {
            /*
             对象（Object）类型
            对象（Object）类型 是 C# 通用类型系统（Common Type System - CTS）中所有数据类型的终极基类。Object 是 System.Object 类的别名。
            所以对象（Object）类型可以被分配任何其他类型（值类型、引用类型、预定义类型或用户自定义类型）的值。但是，在分配值之前，需要先进行类型转换。
            当一个值类型转换为对象类型时，则被称为 装箱；另一方面，当一个对象类型转换为值类型时，则被称为 拆箱。

            用户自定义引用类型有：class、interface 或 delegate
             */
            object obj;
            // 自动装箱
            obj = 100;
            obj = 2.307;

            Console.WriteLine(obj);

            /*
             动态（Dynamic）类型
            可以存储任何类型的值在动态数据类型变量中。
            这些变量的类型检查是在运行时发生的。
            动态类型与对象类型相似，但是对象类型变量的类型检查是在编译时发生的，
            而动态类型变量的类型检查是在运行时发生的。
             */
            dynamic d = 20;
            d = obj;
            d = new Random();

            Console.WriteLine(d);

            /*
             字符串（String）类型
            字符串（String）类型 允许您给变量分配任何字符串值。
            字符串（String）类型是 System.String 类的别名。
            它是从对象（Object）类型派生的。
            字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。
            
             */
            string s1 = "hello world";
            string s2 = @"hello world";


            // C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待

            // 编译错误，无法识别的转义序列
            // string s3 = "C:\windows";  
            string s4 = "C:\\windows";
            string s5 = @"C:\windows";

            string s6 = @"<script type=""text/javascript"">
    <!--
    -->
</script>";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);


            /*
             指针类型（Pointer types）
指针类型变量存储另一种类型的内存地址。C# 中的指针与 C 或 C++ 中的指针有相同的功能。

            type* identifier;
             */

            //指针和固定大小缓冲区只能在不安全的上下文中使用
            // unsafe public ...
            // char* cptr;
            // Console.WriteLine(cptr);

            Console.ReadKey();
        }
    }
}
