using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 0xFF;
            byte c = (byte)(b >> 2);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
