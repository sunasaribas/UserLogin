using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            int giris = 0;
            do
            {
                Console.WriteLine("Kullanıcı adını giriniz:");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz:");
                string sifre = Console.ReadLine();

                if (kullaniciAdi.ToLower() == "admin" && sifre.ToLower() == "123")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{giris + 1}. kez giriş yaptınız. Kalan hakkınız {3 - giris}");
                }

                if (giris == 3)
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Program çıkılıyor..");
                    Console.ReadKey();
                    return;
                }while (giris < 3) ;

                Console.WriteLine("Hoş geldin admin..");

                Console.ReadKey();
            }
        }
    }
}
