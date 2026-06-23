using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi uzunluğunu girin=");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine("Dizi elemanlarini girin=");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Dizi Elemanları =");
            int enbuyuk = dizi[0];
            int enkucuk = dizi[0];

            foreach(int eleman in dizi)
            {
                if(eleman > enbuyuk)
                {
                    enbuyuk = eleman;
                }
                if (eleman < enkucuk)
                {
                    enkucuk = eleman;
                }
            }
            Console.WriteLine("en kucuk eleman=" + enkucuk);
            Console.WriteLine("en buyuk eleman=" + enbuyuk);

            Array.Sort(dizi);
            foreach (int eleman in dizi)
            {
                Console.Write(eleman);
            }
            Console.WriteLine("Sıralanmış Dizi=" + dizi);




            Array.Reverse(dizi);
            foreach(int eleman in dizi)
            {
                Console.Write(eleman);
            }
            Console.Write("Tersine Sıralanmış Dizi=" + dizi);

            //uzunluk bulma
            int toplam = 0;
            foreach(int eleman in dizi) {
                toplam += eleman;
            }
            int ortalama = toplam / dizi.Length;
            Console.WriteLine("dizi uzunluğu=" + dizi.Length);
            Console.WriteLine("dizi ortalaması=" + ortalama);
            Console.ReadKey();


        }
    }
}
