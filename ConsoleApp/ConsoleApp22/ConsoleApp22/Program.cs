using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Birinci sayiyi gir:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi gir:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();   //private tanımladığım Metodu Main içinde kullanıyorsam nesne oluşturmak zorundayım.
            // Metodu static tanımlasaydım bu method için nesne üretmem gerekmezdi.
            // Static Methodu aynı sınıf içerisinden çağıracaksak sadece adını yazarak erişebiliriz.
            // Kendi sınıfının dışında bir yerden çağıracaksak sınıfAdı.Metot olarak erişebiliriz.Nesne oluşturmana gerek yok.
            int toplamsonuc =p.Topla(sayi1, sayi2);
            Console.WriteLine("Toplam sonuc:" +toplamsonuc);

            int farksonuc = p.Fark(sayi1, sayi2);
            Console.WriteLine("Fark sonuc:" + farksonuc);

            int bolumsonuc = p.Bol(sayi1, sayi2);
            Console.WriteLine("Bölüm sonuc:" +bolumsonuc);

            int carpimsonuc = p.Carp(sayi1, sayi2);
            Console.WriteLine("Çarpım sonuc:" + carpimsonuc);

            int modsonuc = Mod(sayi1, sayi2);   // Static bir metodu kendi sınıfından çağırmak için direkt Adını yazıp çağır.
            //Burada static bir methodun nasıl çağrıldığını görüyoruz.
            // class Program sınıfı hem Main hem de aşağıda yazdığımız tüm kodları kapsar.
            Console.WriteLine("Mod sonuc:" + modsonuc);

            string yazi;
            Console.Write("ekrana yazdirmak istediginiz yaziyi girin:");
            yazi = Console.ReadLine();
            // zaten önceden oluşturduğumuz bir nesne var. O nesne üzerinden EkranaYaz Methoda erişelim.
            p.EkranaYaz(yazi);
            p.EkranaYaz("MERHABA");

            Console.ReadKey();
        }
        
        private int Topla(int a, int b)
        {
            return a + b;
        }

        private int Fark(int o, int p)
        {
            return o - p;
        }

        private int Carp(int x,int y)
        {
            return x * y;
        }

        private int Bol(int m,int k)
        {
            return m / k;
        }

        static int Mod(int e,int f)
        {
            return e % f;    //Mod alma metodunu static olarak tanımladık.
        }

        private void EkranaYaz(string girilen)
        {
            Console.WriteLine(girilen);  
            //geri değer döndürmeyen ama string parametre alan fonksiyon tanımladım
            // Metot private olduğu için Main fonksiyonunda nesne oluşturmak gerekir.
            //Ama bizim daha önce oluşturuduğumuz nesneyi hem topla hem carp hem bol,mod,fark hem yazdır gibi
            // tüm fonksiyonlarında kullanabilirsin.
            //yani 1 tane nesne oluşturmak yeterlidir.
        }



            
    }
}

//METOT PARAMETRELERİ
//Değer (value) parametresi ve Referans parametresi olarak 2 ye ayrılır.Bunlar bellekte farklı yerlerde saklanırlar.
//Değer Tipleri int,long,float,double,char,structure,union,short ...
//Refereans Tipleri = string, object, class, interface, arrays ...
//Bir methoda parametre olarak değer tipinde değişken verdiğin zaman bellekte yeni bir alan oluşturulur ve 
//bu değişkenin bu nesnenin taşıdığı yerin bir kopyası oluşturulup bu alana yerleştiriliyor burada önemli olan
//Method içerisinde yapılan işlemde yeni oluşturulan bölgedeki veri kullanılıyor.
//Metot dışında tanımlanan değerin etkilenmediğini görürüz burada.
//Metot içerisinde yapılan değişiklikler method dışında tanımladığımız nesneyi, değişkeni etkilemiyor.

//Referans tipi değişken bellekte yeni bir alan oluşturdu ancak değişkenin bellekteki adresi bu yeni yere yerleşiyor.
//Yani method içerisinde elimizde olan referans ile ilgili değişiklik yaptığımız zaman asıl nesneyi değiştirmiş oluyoruz.
//yani referans tipler referans olarak aktarım sağlıyor.
//Metot içerisinde değişiklik yapatığın zaman Metot dışında tanımladığın bu referans değişkenin değeri değişmiş oluyor

//Eğer bizim elimizdeki parametre bir değer tipindeyse biz bunu referans olarak gösterebiliriz.
//bunun için ref anahtar sözcüğünü kullanmamız gerekiyor. 
//Yani değer tipindeki bir parametreyi zorlayarak referans tipi olarak methoda geçirebiliriz.
//Artık method içerisinde değişiklik yapıldığı zaman değerimizin değeri değişecektir.
//ref anahtar sözcüğünü kullanırken mutlaka ilk değerinin verilmiş olması gerekir.






