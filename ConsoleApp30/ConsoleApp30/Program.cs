using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        public class Musteri
        {
            public int ID;
            public string Name;

            public Musteri(int id,string name)   //YAPICI METODUMUZU OLUŞTURDUK.
            {
                this.ID = id;    //THİS REFERANS GİBİDİR. CLASS MUSTERİ SINFIINDAKİ VERİLERİ GETİRİR.
                this.Name = name;
            }

        }
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(1, "Ali");  
            Console.WriteLine(musteri1.ID + " " + musteri1.Name);
            Musteri musteri2 = new Musteri(2, "İrem");
            Console.WriteLine(musteri2.ID + " " + musteri2.Name);
            Musteri musteri3 = new Musteri(3, "Ahmet");
            Console.WriteLine(musteri3.ID + " " + musteri3.Name);
            Musteri musteri4 = new Musteri(4, "Yasemin");
            Console.WriteLine(musteri4.ID + " " + musteri4.Name);

            Console.ReadKey();

        }
    }
}

//Constructor sınıfın nesnesi yaratıldığı anda otomatik çağrılan metotdur.
//bu metot ait olduğu sınıf üyelerine field (ilk değerlerinin) atamasını yapar.
//sınıf içerisinde bir yapıcı metot tanımlanmasa bile parametresiz varsayılan metot üyelere ilk değerini atamak için otomatik üretilir
//geri dönüş değeri almazlar
//Yapıcı metotlar sınıf ismi ile aynı ismi almak zorundadır.
//yapıcı metotlar aşırı yükleme overloading olabiliyor.
// Nesne ürettiğimiz zaman compiler zaten constructor (yapıcı metot üretiyor);

