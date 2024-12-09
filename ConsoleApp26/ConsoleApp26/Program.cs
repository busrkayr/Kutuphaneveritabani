using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int k = 34;
            OrnekMethod(i);
            Console.WriteLine(i);
            OrnekMethod2(ref k);
            Console.WriteLine(k);
            int sum;
            int carp;
            Hesapla(10, 20, out sum, out carp);
            Console.WriteLine("Toplam sonuc: {0} ve Çarpım sonuc: {1} ", sum, carp);
            Console.ReadKey();
        }

        public static void OrnekMethod(int a)
        {
            a = 100;
            // i değişkenimizi methoda parametre olarak gönderdik ancak hiçbir şekilde İ değişkenimiz sonuçtan etkilenmedi.
            //Değer tipi değişken olduğu için etkilenmedi.
        }


        public static void OrnekMethod2(ref int b)
        {
            b = 500;      //int b değişkeni aslında Değer tipidir ama ref ile referans tipi olarak davranmasını sağladık.
        }

        public static void Hesapla(int firstno, int secondno, out int toplam, out int carpim)
        {
            toplam = firstno + secondno;
            carpim = firstno * secondno;    //out birçok değer geriye döndürülecekse kullanılır
                                            // Bu soruda çarpım ve toplamları geriye değer döndüreceğim.
        }
        

    }



 }




//METHOD PARAMETRELERİ
//Değer (value) parametresi
//Referans parametresi
//Çıkış(out) parametresi
//Parametre Dizisi
//Veri tipleri 2 ye ayrılır : Değer Tipleri ve Referans Tipleri
//Bunlar bellekte farklı yerlerde saklanırlar.
//Değer Tipleri int,float,long,double,char,structure,union,short ...
//Referans Tipleri string,object,class,interface,arrays ...
//Bir methoda parametre olarak değer tipi değişken verdiğinde bellekte yeni bir alan oluşturur
//Bu yeni alana değişkenin(nesnenin) kopyasını oluşturur.
//Method içerisinde yapılan işlem ve değişiklikler, method dışında tanımlanan değişkeni etkilenmiyor.
//Referans tipi değişkende yeni bir alan oluşturulur ancak değişkenin adresi bellekteki alana yerleştirilir.
//Bu durumda method içerisinde değişiklik yaptığımız zaman method dışında tanımlanan asıl nesne(değişken) değişmiş oluyor.
//bu yüzden referans değişkeni kullanırken dikkat et.
//Bizim elimizdeki parametre eğer Değer Tipindeyse biz onu referans olarak gösterebiliriz.
//ref anahtar sözcüğü kullanarak Değer tipindeki parametreyi zorla Referans tipe geçirebiliriz.
//ref anahtar sözcüğü kullandığın için method içerisinde değişiklik yaptığımız zaman
//method dışında tanımlanan asıl nesne(değişken) değişmiş olur.
//ref anahtar sözcüğü parametre olarak kullanılırken mutlaka ilk değerinin verilmiş olması gerekir.

