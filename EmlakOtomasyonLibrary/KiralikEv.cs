using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonLibrary
{
    public class KiralikEv : Ev
    {
        public double Depozito { get; set; }

        public KiralikEv(
            int odaSayisi,
            int katNumarasi,
            string semti,
            double alani,
            int yapimTarihi,
            EmlakTuru turu,
            int emlakNumarasi,
            double depozito
            ) : base(
                odaSayisi,
                katNumarasi,
                semti,
                alani,
                yapimTarihi,
                turu,
                emlakNumarasi)
        {
            Depozito = depozito;
        }

        public override string EvBilgileri()
        {
            return base.EvBilgileri() + $"\nDepozito: {Depozito}";
        }

    }
}
