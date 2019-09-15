using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class manu
    {
        public virtual void hi()
        {
            Console.WriteLine("hi");
        }
    }
    class sravan : manu
    {
        public override void hi()
        {
            Console.WriteLine("bye");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            manu obj = new sravan();
            obj.hi();
            Console.ReadLine();
        }
    }
}
    


