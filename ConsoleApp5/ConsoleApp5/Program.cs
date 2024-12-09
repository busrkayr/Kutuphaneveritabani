using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayi girin=");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi girin=");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if(sayi1 > sayi2)
            {
                if(sayi1%sayi2==0)
                {
                    Console.WriteLine("tam bölenidir");
                }
                else
                {
                    Console.WriteLine("tam bölünmez.");
                }
            }
            if (sayi2 > sayi1)
            {
                if (sayi2 % sayi1 == 0)
                {
                    Console.WriteLine("tam bölenidir");
                }
                else
                {
                    Console.WriteLine("tam bölünmez.");
                }
            }
            Console.ReadKey();


        }
    }
}
