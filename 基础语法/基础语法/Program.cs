using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("666");

            Cat cat = new Cat();

            cat.PrintInfo();

            Console.ReadKey();
        }
    }
}
