using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnek3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği 2 sayı arasındaki çift sayıları yazdıran, ve bu çift sayıların adetini ve toplamını bularak ekranda gösteren C# Console Örneği.

            int s1, s2;
            int toplam = 0, sayac = 0;
            Console.Write("Lütfen birinci sayıyı giriniz :");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz :");
            s2 = Convert.ToInt32(Console.ReadLine());
            for (int i = s1; i <= s2; i++)
            {



                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    sayac++;
                    toplam = toplam + i;



                }



            }
            Console.WriteLine(" {0}  ile  {1}  arasında {2} adet çift sayı vardır. Bu çift sayıların toplamı = {3} ", s1, s2, sayac, toplam);


            //Arka arkaya girilen rastgele 10 tamsayının ortalaması ile bu sayılardan en büyük ve en küçük olanının ortalamasını bularak elde edilen bu iki ortalamanın farkını alan sonuçta tüm sayıların ortalaması,
            //en küçük sayı,en büyük sayı küçük büyük sayıların ortalamasını gösteren C# Console Örneği.


            //int sayi, buyuk, kucuk, ortalama, buyukkucukortalama;
            //int toplam = 0;
            //Console.Write("Lütfen Sayı Giriniz = ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //kucuk = sayi;
            //buyuk = sayi;
            //toplam += sayi;
            //for (int i = 0; i < 10; i++) {
            //    Console.Write("Lütfen Sayi giriniz = ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;



            //    if (sayi > buyuk) {

            //        buyuk = sayi;
                
            //    }
            //    if (sayi < kucuk) {

            //        kucuk = sayi;
            //    }
            
            
            
            //}
            //ortalama = toplam / 10;
            //buyukkucukortalama = (buyuk + kucuk) / 2;
            //Console.WriteLine("Girilen en küçük sayı = {0}", kucuk);
            //Console.WriteLine("Girilen en büyük sayı = {0}", buyuk);
            //Console.WriteLine("Girilen sayıların ortalaması = {0}",ortalama);
            //Console.WriteLine("Girilen en büyük ve en küçük sayının ortalaması = {0}",buyukkucukortalama);
            //Console.WriteLine("Ortalamaların farkı = {0}",ortalama-buyukkucukortalama);
            //Console.ReadLine();








        }
    }
}
