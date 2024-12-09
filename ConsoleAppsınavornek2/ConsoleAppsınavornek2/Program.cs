using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppsınavornek2
{
    class Araba
    {
        public int kapiSayisi;
        public string arabaModeli;
        public string arabaRengi;

        public Araba()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba arb1 = new Araba();
            arb1.kapiSayisi = 4;
            arb1.arabaModeli = "Renault";
            arb1.arabaRengi = "Kırmızı";

            Console.WriteLine("Arabanın kapı sayısı :" + arb1.kapiSayisi);
            Console.WriteLine("Arabanın Modeli :" + arb1.arabaModeli);
            Console.WriteLine("Arabanın rengi :" + arb1.arabaRengi);
            Console.ReadKey();
        }
    }
}
