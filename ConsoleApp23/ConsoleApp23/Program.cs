using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            OrnekMethod(i);
            Console.WriteLine(i);
            Console.ReadKey();
        }

        public static void OrnekMethod(int a)
        {
            a = 100;
        }


        // i değişkenimizi methoda parametre olarak gönderdik ancak hiçbir şekilde İ değişkenimiz sonuçtan etkilenmedi.
        //Değer tipi değişken olduğu için etkilenmedi.

    }
}
