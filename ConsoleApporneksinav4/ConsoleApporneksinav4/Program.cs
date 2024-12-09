using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApporneksinav4
{
    
        class Karmasiksayi
        {
            public double mGercek;
            public double mSanal;

           
            public Karmasiksayi(double x,double y)
            {
                mGercek = x;
                mSanal = y;
            }

            public Karmasiksayi()
            {
                mGercek = 0;
                mSanal = 0;
            }

            public Karmasiksayi(Karmasiksayi k)
            {
                mGercek = k.mGercek;
                mSanal = k.mSanal;
            }

            public void Yaz ()
            {
                if (mSanal > 0)
                {
                    Console.WriteLine("{0} + {1}i", mGercek, mSanal);
                }
                else
                {
                    Console.WriteLine("{0} - {1}i", mGercek, mSanal);

                }

            }

        
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            Karmasiksayi k = new Karmasiksayi(-5, -6);
            k.Yaz();
            Console.ReadKey();
        }
    }
}
