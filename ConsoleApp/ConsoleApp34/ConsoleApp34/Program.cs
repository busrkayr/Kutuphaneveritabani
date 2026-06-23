using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class KarmasikSayi
    {
        private double mGercek;
        private double mSanal;

        public double Gercek
        {
            get { return mGercek; }
            set { mGercek = value; }  
        }

        public double Sanal
        {
            get { return mGercek; }
            set { mGercek = value; }
        }

        public KarmasikSayi(double x,double y)
        {
            mGercek = x;
            mSanal = y;
        }

        public KarmasikSayi(KarmasikSayi k)
        {
            mGercek = k.mGercek;
            mSanal = k.mSanal;
        }

        public void Yaz()
        {
            if (mSanal > 0)
                Console.WriteLine("{0]+{1]i", mGercek, mSanal);
            else
                Console.WriteLine("{0]-{1]i", mGercek, mSanal);
        }
            
        public static KarmasikSayi operator +(KarmasikSayi k1, KarmasikSayi k2) {
            KarmasikSayi z = new KarmasikSayi();
            double x = k1.a + k1.b;
            double y = k2.a + k2.b;
            return z;
        }

    public static KarmasikSayi operator (KarmasikSayi k1, KarmasikSayi k2)
    {
        double x = k1.a - k2.a;
        double y = k2.a - k2.b;
        return new KarmasikSayi(x - y);
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            KarmasikSayi k1 = new KarmasikSayi(-5, -6);
            KarmasikSayi k2 = new KarmasikSayi(4, 7);
            KarmasikSayi t = k1 + k2;
            t.Yaz;
        }
    }
}
