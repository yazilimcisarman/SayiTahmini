using System;

namespace SayiTahmini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı tahmin uygulamasına hoşgeldin.");
            Console.WriteLine("3 hakkınız vardır !!!");
            Console.WriteLine("Sayı 0 ile 20 arasında bir sayı.");
            Console.WriteLine("Tahminini gir:");
            Random random = new Random();
            int sayi = random.Next(0, 20);
            bool success = true;
            int tahmin, say = 0;
            while (success && say <= 2)
            {
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (sayi == tahmin)
                {
                    Console.WriteLine("Tebrikler!!!!!!! \nSayıyı bildin.");
                    success = false;
                }
                else
                {
                    if (say == 2)
                    {
                        Console.WriteLine("Sayıyı bulamadın, sayı: " + tahmin);
                    }
                    else
                    {
                        Console.WriteLine("Sayıyı bilemedin, tekrardan sayı gir");
                    }
                    say++;
                }
            }


            Console.ReadLine();
        }
    }
}
