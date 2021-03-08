using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç elemanlı bir dizi istiyorsunuz?");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[num];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("dizinin "+ i + ". elemanını giriniz lütfen");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("****************");

            for (int i = 0; i <= sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
