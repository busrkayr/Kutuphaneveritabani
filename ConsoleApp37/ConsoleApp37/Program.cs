using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{

    class ana
    {
        public ana() { }
    }
    class yavru : ana 
    {
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            yavru y = new yavru();
            Console.ReadKey();
        }
    }
}
//önce temel sınıfın yapıcısı sonra türemiş sınıfın yapıcısı çalışıyor. temel sınıfın yapıcısı var ama imzaları uymuyor. HATA