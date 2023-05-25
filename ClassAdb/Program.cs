using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdb
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //소멸자 실습
            Product product1 = new Product("탕후루", 3000);
            Product product2 = new Product("핫도그", 2000);
            Product product3 = new Product("이클립스", 3000);
            Console.WriteLine("안녕하세요.");
        }
    }
}
