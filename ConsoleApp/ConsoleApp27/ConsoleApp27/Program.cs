using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topla(10, 20);
            Topla(10, 20, 30);
            Topla(10, 20, 4.555f);
            Topla(1.2f, 3.5f);
            Console.ReadKey();

        }

        static void Topla(int a,int b)
        {
            int sonuc = a + b;
            Console.WriteLine("1.method çağrıldı Sonuc:" + sonuc);
        }
        static void Topla(int a, int b, int d)
        {
            int sonuc = a + b + d;
            Console.WriteLine("2.method çağrıldı Sonuc:" + sonuc);
        }
        static void Topla(int a, int b, float c)
        {
            float sonuc = a + b + c;
            Console.WriteLine("3.method çağrıldı Sonuc:" + sonuc);
        }
        static void Topla(float a, float b)
        {
            float sonuc = a + b;
            Console.WriteLine("4.method çağrıldı Sonuc:" + sonuc);
        }

    }
}
//METOTLARIN AŞIRI YÜKLENMESİ(METHOD OVERLOADİNG)
//Aynı isimli birden fazla method tanımlamak anlmaına gelmektedir.
//Metotlara aynı isim verildiğinde hangi methodun çağrılacağına Derleyici Metot imzasına bakarak karar verir.
//Method imzası(Method signature) : Metodun adı, paramatrelerin tipi, türü(reference,değer,out) ve parametre sayısından oluşur.