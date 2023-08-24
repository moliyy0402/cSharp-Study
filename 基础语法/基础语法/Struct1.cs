using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础语法
{
    struct Books {
        internal string title; 
        internal string author; 
        internal string subject; 
        internal int book_id;
        internal double price;

        public void printInfo()
        {
            Console.WriteLine("Books(title={0},author={1},subject={2},book_id={3},price={4})",
                title,author,subject,book_id,price
                );
        }
    }
    internal class Struct1
    {
        public static void demo01()
        {
            Books b = new Books();
            b.title = "三国演义";
            b.author = "罗贯中";
            b.subject = "历史";
            b.book_id = 1001;
            b.price = 35.9;

            b.printInfo();
        }
    }
}
