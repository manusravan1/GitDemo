using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    sealed class manu
    {
        public void show()
        {
            Console.WriteLine("hi");
        }
        public static void no()
        {
            Console.WriteLine("bye");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            manu obj = new manu();
            obj.show();
            manu.no();
            Console.ReadLine();
        }
    }
}
