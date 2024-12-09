using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{

    public class Musteri
    {
        public int ID;
        public string Name;  //sınıfın özelliklerini tanımladık
        public string Surname;

        public void Info()
        {
            Console.WriteLine("Müşteri bilgileri ID = {0} , Name = {1}{2}", ID, Name, Surname);  //Sınıfın metodunu tanımladık
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();   // Musteri sınıfından m1 nesnesi oluşturduk
            m1.ID = 1;
            m1.Name = "Busra";
            m1.Surname = "Kayir";

            Musteri m2 = new Musteri();   // Musteri sınıfından m2 nesnesi oluşturduk
            m2.ID = 2;
            m2.Name = "Yasemin";
            m2.Surname = "Kayir";

            Musteri m3 = new Musteri();   // Musteri sınıfından m3 nesnesi oluşturduk
            m3.ID = 3;
            m3.Name = "Yusuf";
            m3.Surname = "Kayir";

            m1.Info();
            m2.Info();
            m3.Info();




            Console.ReadKey();
        }
    }
}

//Sınıf 2 ana kıısmdan oluşur değişkenler ---> nitelik(özellikler)
// metotlar ---> davranışlar
