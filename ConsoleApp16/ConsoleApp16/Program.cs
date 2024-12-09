using System;
class Program
{
    
    static void Main(string[] args)
    {
        
        int[,] dizi = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        
        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for (int j = 0; j < dizi.GetLength(1); j++)
            {
                Console.Write(dizi[i, j] );
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }    
}
