using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3, carp;
            Console.Write("birinci Sayi gir=");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci Sayi gir=");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu Sayi gir=");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            carp = sayi1 * sayi2 * sayi3;
            Console.WriteLine("Çarpım=" + carp);


            Console.ReadKey();




        }


           
     }
}

