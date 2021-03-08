using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekCift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int ciftAdetToplam =0;
            int CiftSayilarinToplami= 0;

            int tekAdetToplam=0;
            int tekSayilarinToplami=0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine((i + 1) + ". değeri giriniz.");
                int kullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = kullaniciDeger;
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    CiftSayilarinToplami += sayilar[j];
                }
                else
                {
                    tekAdetToplam++;
                    tekSayilarinToplami += sayilar[j];
                }

            }
            Console.WriteLine("Çift sayıların toplamı :"+ CiftSayilarinToplami);
            Console.WriteLine("Çift sayıların adeti :"+ ciftAdetToplam);
            Console.WriteLine("****************************");
            Console.WriteLine("Tek sayıların toplamı :" + tekSayilarinToplami);
            Console.WriteLine("Tek sayıların adeti :" + tekAdetToplam);
            Console.ReadLine();
        }
    }
}
