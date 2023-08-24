using System;

namespace 基础语法
{

    /// <summary>
    /// 枚举本质是int，元素从0开始一一对应
    /// </summary>
    internal enum Day { Sun=4, Mon, Tue, Wed, Thu=9, Fri, Sat };
    internal class enums1
    {
        public static void demo01()
        {
            Day day = Day.Fri;

            int d = (int)day;          
            string s = day.ToString();

            Day d1 = (Day) Enum.Parse(typeof(Day),"7");

            Console.WriteLine(day);
            Console.WriteLine(d);
            Console.WriteLine(s);

            Console.WriteLine(d1);
        }

        public static void demo01(int aa) { 

        } 
    }
}
