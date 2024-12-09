using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{

    class Hayvan //temel sınıf
    {
        public double boy;
        public double agirlik;
        public void OzellikGoster()
        {
            Console.WriteLine("Boy ="+boy);
            Console.WriteLine("Agirlik ="+agirlik);
        }
    }

    class Kedi : Hayvan//türetilmiş sınıf
    {
        public string Turu;
        public void TurGoster()
        { Console.WriteLine("Tur ="+Turu); }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi k1 = new Kedi();
            k1.agirlik = 5;
            k1.boy = 10;
            k1.Turu = "Van";
            k1.OzellikGoster();
            k1.TurGoster();

            Hayvan h1 = new Hayvan();
            h1.agirlik = 5;
            h1.boy = 10;
            //h1.Turu=“van”; //HATA!!!
            h1.OzellikGoster();
            //h1.TurGoster(); //HATA!!!
            Console.ReadKey();
        }
    }
}
