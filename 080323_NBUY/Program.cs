using System;

namespace _080323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arac arac1 = new arac();
            arac1.marka = "vw";
            arac1.model = 2007;
            arac1.yakitTipi = "benzin";
            arac1.renk = "siyah";
            arac1.vites = "otomatik";

            arac arac2 = new arac();
            arac2.marka = "reno";
            arac2.model = 2020;
            arac2.yakitTipi = "benzin";
            arac2.renk = "kırmızı";
            arac2.vites = "manuel";


            musteri musteri1 = new musteri();
            musteri1.ad = "Ali";
            musteri1.soyad = "Durmadı";

            musteri musteri2 = new musteri();
            musteri2.ad = "Veli";
            musteri2.soyad = "Durdu";

            alim(musteri1, arac1);
            alim(musteri2, arac2);


            static void alim(musteri m, arac n)
            {
                Console.WriteLine(m.ad + " " + m.soyad + " " + n.marka + " " + n.model + " " + n.renk + " " + n.vites + " " + n.yakitTipi + " yakıtlı " + "arac aldı");

            }


        }


    }
}




