using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReferenceType refer = new ReferenceType();
            refer.valueVal = 5;
            Test(refer);
            Console.WriteLine("teh value of the variable is {0}", refer.valueVal);
            Console.ReadLine();
        }
        static void Test(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }
    }
}
