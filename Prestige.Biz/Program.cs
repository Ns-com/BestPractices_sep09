using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    class Program
    {
       //Pascal casing for const and readOnly;
        public const int ConstantNum= 100;
        public static readonly int ReadOnlyNum= 0;
        static Program()
        {
            ReadOnlyNum = 300;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(ConstantNum);
            Console.WriteLine(ReadOnlyNum);
        }
    }
}
