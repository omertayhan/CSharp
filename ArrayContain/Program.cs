using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 21, 21, 20, 30, 50, 60, 70, 80, 30, 25, 15, 35, 87, 90 };
            int adet = 0;
            int sayi;

            Console.WriteLine("Sayıyı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayi == sayilar[i])
                {
                    adet++;
                }
            }

            if(adet == 0)
            {
                Console.WriteLine("Girdiğiniz sayı dizide bulunmamaktadır.");
            }
            else {
                Console.WriteLine("Girdiğiniz sayı dizide bulunmaktadır, "+ adet + " tanedir");
            }
            Console.ReadLine();
        }
    }
}
