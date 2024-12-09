using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApporneksinav3
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Toplam p = new Toplam();
            int sonuc = p.Topla(2, 3);
            Console.WriteLine("toplam sonuc: " +sonuc);
            Console.ReadKey();

        }
    }

    class Toplam
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
    }
}
