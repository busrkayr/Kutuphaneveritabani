using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Nokta
    {
        public int x, y;

        public void Goster()
        {
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }

        public void Goster(Nokta n)
        {
            double uz;
            uz = Math.Sqrt((this.x - n.x) * (this.x - n.x) + (this.y - n.y) * (this.y - n.y));
            Console.WriteLine("iki nokta arasındaki mesafe=" + uz);
        }
        public void Git(int x1,int y1)
        {
            x = x1;
            y = y1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nokta N1 = new Nokta();
            Nokta N2 = new Nokta();

            N1.Goster();
            N2.Goster();

            N1.Git(50, 100);
            N1.Goster();

            N2.Git(25, 30);
            N2.Goster();

            N1.Goster(N2);
            N2.Goster(N1);


            Console.ReadKey();
        }
    }
}
