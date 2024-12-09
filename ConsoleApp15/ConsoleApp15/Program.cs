using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int[] dizi = new int[5];
            
            for (int i=0; i<5; i++)
            {
                dizi[i] = rnd.Next(5,11);
                Console.WriteLine(dizi[i]);
            }

         
            Console.ReadKey();

        }
    }
}
