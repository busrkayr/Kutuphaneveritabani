using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program    //Burada program adında bir Sınıf oluşturulmuş
    {
        static void Main(string[] args)  //Burada statik, geriye değer döndürmeyen Main Methodu otomatik olarak oluşturulmuş durumdadır.
        {

            Program t = new Program();
            Console.WriteLine("Birinci sayiyi girin=");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi girin=");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc= t.Toplam(sayi1, sayi2);
            Console.WriteLine("Toplam Sonuç:" + sonuc);
            
            Console.ReadKey();


        }

        private int Toplam(int a, int b)
        {
            
            return a + b;
        }
    }
}


//Method programın herhangi bir yerinde kullanılmak için tasarlanmış program parçacıklarıdır. 
//Methodlar tek başına bir anlam ifade etmezler.
//metotlar mutlaka sınıf içerisinde bildirilmelidir.
//Metot mutlaka sınıf içinde oluşturulmak zorundadır.
//Sınıf içerisinde oluşturulmayan Metotlar kullanılamaz. 
//Method erişim belirteci(Methoda nereden erişilebileceğini gösteren kısım), Geri dönüş değeri(return type = int float), Method ismi, Parametreleri olabilir.
//Parametreler opsiyoneldir.Parametresi olmayan Method tanımlayabilirsin. Olmak zorunda değil.
//Methodun Geriye dönüş değeri Void olabilir.
//Tanımladığımız nesne üzerinden Methodumuza erişebiliriz.
//Bu methodu içeren sınıf üzerinden nesne oluşturmamız lazım
//Program üzerinden nesne tanımlıyoruz.Program sınıfından nesne ürettik
//t.Toplam nesne yanına nokta koyunca nesne üzerinden ulaşabileceğimiz Methodları görürüz.
//Program çalıştı
//Nesne oluşturuldu
//Toplam Methodu çalıştırıldır. Toplama yapıldı.Feri dönüş değeri sonuç değişkenine atandı.
//Konsol erkranına grri dönüş değeri yazdırıldı.