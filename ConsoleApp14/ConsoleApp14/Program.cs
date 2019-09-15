using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class manu
    {
        public int king(int a,int b)
        {
            return a + b;
        }
        public int king(int a,int b,int c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            manu obj = new manu();
           int d= obj.king(10, 20);
            Console.WriteLine("add values is:" + d);
            int e = obj.king(10, 20, 30);
            Console.WriteLine("add values is:" + e);
            Console.ReadLine();
        }
    }
}
