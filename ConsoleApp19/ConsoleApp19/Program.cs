using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, topla, carp, bol, fark,mod;
            Console.WriteLine("Sayi gir=");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi gir=");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            topla = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carp = sayi1 * sayi2;
            bol = sayi1 / sayi2;
            mod = sayi1 % sayi2;
            Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, topla);
            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);
            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carp);
            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bol);
            Console.WriteLine("{0} % {1} = {2}", sayi1, sayi2, mod);

            Console.ReadKey();

        }
    }
}


