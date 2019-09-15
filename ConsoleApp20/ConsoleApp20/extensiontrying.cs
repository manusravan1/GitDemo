using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    static class extensiontrying
    {
            public static void method3(this Program obj,int i)
            {
                Console.WriteLine("sravan");
            }
        public static string Toproper(this String oldstr)
        {
            if(oldstr.Trim().Length>0)
            {
                String newstr = null;
                oldstr = oldstr.ToLower();
               string[]s= oldstr.Split(' ');
                foreach(string str in s)
                {
                   char[]cr = str.ToCharArray();
                    cr[0]=
                }
            }
            return oldstr;
        }
    }
}
