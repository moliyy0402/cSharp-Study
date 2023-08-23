using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    public class Cat
    {
        private String name;
        private int age;

        public void PrintInfo() {
            Console.WriteLine("cat类的名字是：{0}，年龄是{1}",name,age);
        }

        public Cat(string name, int age) {
            this.name = name;
            this.age = age;
        }

    }
}
