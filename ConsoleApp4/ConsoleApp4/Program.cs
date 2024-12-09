using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Lutfen 10 tane sayi giriniz:");
            for (int i = 0; i < 10;)
            {
                Console.Write("Sayi {0}: ", i + 1);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    i++;
                }
                else
                {
                    Console.WriteLine("Hatali sayi girdiniz. Lutfen tekrar deneyiniz.");
                }
            }
            Console.WriteLine("Girdiğiniz sayilar=");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            Console.WriteLine("Kucukten buyuge siralanmis hali=");
            foreach (int number in numbers)
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
