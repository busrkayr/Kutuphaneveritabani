using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {

        public void Topla(int x, int y)
        {
            Console.WriteLine("Toplam sonuc:", +(x + y));
        }

        public void Main()
        {
            int sayi1, sayi2;
            Console.WriteLine("Birinci sayiyi gir:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi gir:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Topla(sayi1, sayi2);
            Console.ReadKey();


        }
    }
}
