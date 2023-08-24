using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    public class Encapsulation1
    {
        //成员变量
        public double length;
        public double width;

        public double GetArea() {
            return this.length * this.width;
        }

        public void Display() {
            Console.WriteLine("长：{0}",this.length);
            Console.WriteLine("宽：{0}",this.width);
            Console.WriteLine("面积：{0}",this.GetArea());
        }
    }


    internal class Encapsulation2 {
        //成员变量
        private double length;
        private double width;

        public void setVauleForKeys() {
            Console.WriteLine("请输入长：");
            this.length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入宽：");
            this.width = Convert.ToDouble(Console.ReadLine());

        }

        public double GetArea()
        {
            return this.length * this.width;
        }

        public void Display()
        {
            Console.WriteLine("长：{0}", this.length);
            Console.WriteLine("宽：{0}", this.width);
            Console.WriteLine("面积：{0}", this.GetArea());
        }

    }
}
