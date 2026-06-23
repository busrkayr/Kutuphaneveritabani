using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppsinavornek
{
    internal class Program
    {
        private static int x;
        private static int y;

        static void Main(string[] args)
        {
            Deneme d = new Deneme();   //Bir nesnenin oluşturulduğu anda Yapıcı Methodu çalıştırılır.
            Deneme dd = new Deneme(x);
            Deneme ddd = new Deneme(x,y);
            Console.ReadKey();

        }
    }

    class Deneme
    {

        

        public Deneme()
        {
            Console.WriteLine("Yapıcı method çalıştırıldı");
        }

        public Deneme(int a)
        {
            Console.WriteLine("1 parametreli Yapıcı method çalıştırıldı");
        }

        public Deneme(int a,int b)
        {
            Console.WriteLine("2 parametreli Yapıcı method çalıştırıldı");
        }


    }
}

//Yapıcı Method Sınıflardan nesne oluşturulduğu zaman oluşan Methodtur.
//Geriyedönüş tipi yoktur
//Araba sınıfı içerisinde aynı ismi taşıyan geri dönüş tipi olmayacak (void string int) şekilde Constructor yapıcı method çalıştırılır
//Bir nesnenin dinamik olarak yaratıldığı anda otomatik olarak çalıştırılan
//metotlar vardır. Bu metotlar sayesinde bir nesnenin üye elemanlarına ilk
//değerler verilebilir ya da gerekli ilk düzenlemeler yapılabilir. Bu metotlara
//yapıcı metotlar (constructors) denir.
//Yapıcı metot tanımlanmasa dahi her sınıfın varsayılan bir yapıcı
//metodu(default constructor) mutlaka bulunur.
//Bir nesne oluşturulduğunda sayısal değerler için 0, referanslar için null, bool türü için false atanır,
//bu atama bir yapıcı metot ile gerçekleştirilir.
