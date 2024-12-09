using ConsoleApp14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        void Topla(int a, int b)
        {
            int t;
            t = a + b;
            Console.WriteLine("Toplam=" + t);
            Console.WriteLine("Toplam= {0}", t);
            Console.WriteLine($"Toplam={t}");
        }
        static void Main(string[] args)
        {
            Program nesne = new Program();
            nesne.Topla(2, 5);
            Console.ReadKey();
        }
    }

}
   
