using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare
             */
            int[] tabel = new int[2]  ;
            for (int i = 0; i < 2; i++)
            {
                tabel[i]= int.Parse(Console.ReadLine());
            }
            Array.Sort(tabel);
            string myString = String.Join(",", tabel);
            Console.WriteLine(myString);






        }
    }
}
