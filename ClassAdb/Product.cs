using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdb
{
    internal class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        ~Product() 
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }
}
