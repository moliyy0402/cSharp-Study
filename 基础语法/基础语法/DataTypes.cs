using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.ReadKey();
        }

        /*
         * 如需得到一个类型或一个变量在特定平台上的准确尺寸，可以使用 sizeof 方法。
         * 表达式 sizeof(type) 产生以字节为单位存储对象或类型的存储尺寸。下面举例获取任何机器上 int 类型的存储尺寸：
         */
    }
}
