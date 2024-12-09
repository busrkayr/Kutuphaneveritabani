using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Toplama
    {
        private int X;
        private int Y;

        public Toplama()
        {
            X = -1;
            Y = -1;
        }

        public int Islem()
        {
            return X + Y;
        }

        public void Yaz()
        {
            Console.WriteLine("X = {0}", X);
            Console.WriteLine("Y = {0}", Y);
        }

    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama t = new Toplama();
            Console.WriteLine("X:", X);
            Console.WriteLine("y:", y);
            

            Console.ReadKey();
        }
    }
}
