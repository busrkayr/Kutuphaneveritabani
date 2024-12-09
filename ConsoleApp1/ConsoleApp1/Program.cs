using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            List<int> numbers = new List<int>();
            Console.WriteLine("Lutfen 10 tane sayi girin=");
            for(i=0; i<10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("Girdiğiniz sayilar=");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            Console.WriteLine("Kucukten buyuge siralanmis hali=");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Reverse();
            Console.WriteLine("Tersine siralanmis hali=");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
