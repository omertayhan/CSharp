using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            int hak = 3;
            while (kontrol)
            {
                Console.WriteLine("Kullanıcı Adınızı giriniz");
                string isim = Console.ReadLine();

                Console.WriteLine("şifrenizi giriniz");
                string parola = Console.ReadLine();

                if (isim == "admin" && parola == "admin")
                {
                    Console.WriteLine("Başarılı bir şekilde giriş yaptınız...");
                    Console.ReadLine();
                    break;
                }

                if (hak <= 0)
                {
                    Console.WriteLine("Üçten fazla hatalı giriş yaptınız tekrar deneyiniz.");
                    Console.ReadLine();
                    kontrol = false;
                }
                else
                {
                    hak -= 1;
                }
            }
        }
    }
}
