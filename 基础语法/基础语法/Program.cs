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
            Console.WriteLine("666");

            Cat cat = new Cat("桔桔",2);

            cat.PrintInfo();

            Console.ReadKey();
        }
    }
}
