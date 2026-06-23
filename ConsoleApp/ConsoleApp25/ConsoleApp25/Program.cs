using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Methodlar mutlaka sınıf içerisinde oluşturulmalıdır.


namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("Birinci sayiyi gir:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayiyi gir:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();  //Program sınıfından nesne ürettim.Bu nesneyi tüm fonksiyonlar için kullanabilirim

            int toplamsonuc = p.Topla(sayi1, sayi2);
            Console.WriteLine("Toplam sonuc:" + toplamsonuc);

            int farksonuc = p.Fark(sayi1, sayi2);
            Console.WriteLine("Fark sonuc:" + farksonuc);

            int carpimsonuc = p.Carp(sayi1, sayi2);
            Console.WriteLine("Çarpım sonuc:" + carpimsonuc);

            int bolsonuc = p.Bol(sayi1, sayi2);
            Console.WriteLine("Bölüm sonuc:" + bolsonuc);

            int modsonuc = Mod(sayi1, sayi2);
            Console.WriteLine("Mod sonuc:" + modsonuc);

            
            Console.Write("Ekrana yazmak istediğiniz yaziyi girin:");
            string yazi = Console.ReadLine();
            p.EkranaYaz(yazi);
            p.EkranaYaz("merhaba busraa");
            

            int sonuc1 = p.Topla(100, 67);
            Console.WriteLine(sonuc1);
            int sonuc2 = p.Fark(34, 16);
            Console.WriteLine(sonuc2);
            int sonuc3 = p.Carp(33, 11);
            Console.WriteLine(sonuc3);
            int sonuc4 = p.Bol(144, 12);
            Console.WriteLine(sonuc4);

            Console.ReadKey();

        }

        private int Topla(int a, int b)
        {
            return a + b;    //Private kullandığından Main fonksiyonundan Topla methodunu çağırabilmek için nesne tanımlamalısın.
        }

        private int Fark(int x, int y)
        {
            return x - y;    //Private kullandığından Main fonksiyonundan Fark methodunu çağırabilmek için nesne tanımlamalısın.
        }

        private int Carp(int k, int m)
        {
            return k * m;    //Private kullandığından Main fonksiyonundan Carp methodunu çağırabilmek için nesne tanımlamalısın.
        }

        private int Bol(int c, int d)
        {
            return c / d;    //Private kullandığından Main fonksiyonundan Bol methodunu çağırabilmek için nesne tanımlamalısın.
        }


        //Method static tanımlanırsa nesne üretmek gerekmez.
        //Static ve Main aynı sınıftaysa adını yazıp çağırabilirsin.
        //Eğer static ve fonksiyonun çağrıldığı yer (Main) farklı sınıflardaysa sınıfAdı.Method şeklinde çağrılır.

        static int Mod(int e, int f)
        {
            return e % f;
        }

        private void EkranaYaz(string girilen)
        {
            Console.WriteLine(girilen);
        }
    }

}
