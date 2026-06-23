using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Musteri
    {
        public int ID;
        public string Name;
        public string Surname;

        public void Info()
        {
            Console.WriteLine("Musteri ID : {0} Name: : {1}{2}", ID, Name, Surname);
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i<=10; i++)
            {
                Musteri m = new Musteri();
                m.ID = i;
                m.Name = Console.ReadLine();
                m.Surname = Console.ReadLine();
                m.Info();

            }
        }
    }
}
