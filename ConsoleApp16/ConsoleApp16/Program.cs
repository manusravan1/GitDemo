using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    abstract class manu
    {

        internal abstract void jul();
        internal void info()
        {
            Console.WriteLine("hi");
        }
        internal manu()
        {
            Console.WriteLine("constuctor is calling");
        }
        
        ~manu()
        {
            Console.WriteLine("destructor is calling");
        }
        internal int hi
        {
            get;
            set;
        }
      
    }
   

    class sravs :manu
    {
        internal override void jul()
        {
            Console.WriteLine("bye");
        }
    }
    class gadi : manu
    {
        internal override void jul()
        {
            Console.WriteLine("good night");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            manu obj = new sravs();
            obj.jul();
            obj = new gadi();
            obj.jul();
            obj.info();
            

            
            Console.ReadLine();
        }
    }
}
