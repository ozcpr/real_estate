using System;
using EmlakOtomasyonLibrary;
using static EmlakOtomasyonLibrary.Ev;

namespace EmlakConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Ev ev = new Ev(
                odaSayisi: 3,
                katNumarasi: 2,
                semti: "Kadikoy",
                alani: 120.5,
                yapimTarihi: 2010,
                turu: EmlakTuru.Daire,
                emlakNumarasi: 1001
            );

            KiralikEv kiralikEv = new KiralikEv(
                odaSayisi: 3,
                katNumarasi: 2,
                semti: "Kadikoy",
                alani: 120.5,
                yapimTarihi: 2010,
                turu: EmlakTuru.Dubleks,
                emlakNumarasi: 202,
                depozito: 500);

            SatilikEv satilikEv = new SatilikEv(
                odaSayisi: 4,
                katNumarasi: 6,
                semti: "Besiktas",
                alani: 200.3,
                yapimTarihi: 2015,
                turu: EmlakTuru.Dubleks,
                emlakNumarasi: 54774,
                fiyat: 4250000
                );


            Console.WriteLine(ev.EvBilgileri());
            Console.WriteLine("Ev Fiyatı: " + ev.FiyatHesapla());
            Console.WriteLine("\n");
            
            Console.WriteLine(kiralikEv.EvBilgileri());
            Console.WriteLine("\n");

            Console.WriteLine(satilikEv.EvBilgileri());

            // double kiraFiyati = ev.FiyatHesapla();
            // Console.WriteLine("Kira Fiyatı: " + kiraFiyati);

            Console.ReadLine();
        }
    }
}
