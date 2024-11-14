using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonLibrary
{
    public class SatilikEv : Ev
    {
        public double Fiyat { get; set; }

        public SatilikEv(
            int odaSayisi,
            int katNumarasi,
            string semti,
            double alani,
            int yapimTarihi,
            EmlakTuru turu,
            int emlakNumarasi,
            double fiyat) : base(
            odaSayisi,
            katNumarasi,
            semti,
            alani,
            yapimTarihi,
            turu,
            emlakNumarasi)
            {
            Fiyat = fiyat ;
        }

        public override string EvBilgileri()
        {
            return base.EvBilgileri() + $"\nFiyat: {Fiyat}";
        }

    }
}
