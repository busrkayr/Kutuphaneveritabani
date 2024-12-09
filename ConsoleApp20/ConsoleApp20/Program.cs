using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        public static void Welcome(string isim)
        {
            Console.WriteLine("Welcome" + isim);
        }

        public static void Niceday()
        {
            Console.WriteLine("Have a nice day");
        }

        static void Main(string[] args)
        {
            string ad;
            Console.WriteLine("Lutfen isim gir=");
            ad = Console.ReadLine();
            Welcome(ad);
            Niceday();
            Console.ReadKey();

        }
    }
}
