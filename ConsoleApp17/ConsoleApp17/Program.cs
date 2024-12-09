using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
       
        static void Topla1(int b, int a)
        {
            Console.WriteLine(a + b);

        }

        static int Topla2(int b,int a)
        {
            return a + b;
            

        }


        static void Main(string[] args)
        {
            Console.WriteLine("sayi gir=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi gir=");
            b = Convert.ToInt32(Console.ReadLine());
            Topla1(b, a);
            Topla2(b, a);



        }
    }
}
