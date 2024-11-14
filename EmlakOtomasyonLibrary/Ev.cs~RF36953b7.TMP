using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonLibrary
{
    public class Ev
    {

        #region Fields


        private int odaSayisi;
        private int katNumarasi;
        private string semti;
        private double alani;
        private int yapimTarihi;
        private EmlakTuru turu; // TODO: change to enum
        private bool aktif;
        private int emlakNumarasi;
        private double fiyat;
        private double kira;
        private double depozito;

        public enum EmlakTuru
        {
            Daire,
            Bahceli,
            Dubleks,
            Mustakil
        }

        #endregion


        #region Constructor


        public Ev(int odaSayisi, int katNumarasi, string semti, double alani, int yapimTarihi, EmlakTuru turu, int emlakNumarasi)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semti = semti;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Turu = turu;
            Aktif = true; // Default 
            this.emlakNumarasi = emlakNumarasi;
        }


        #endregion


        #region Properties


        public int OdaSayisi
        {
            get => odaSayisi;

            set
            {
                if (value < 0)
                {
                    odaSayisi = 0;
                }
                else
                {
                    odaSayisi = value;
                }
            }

        }

        public int KatNumarasi
        {
            get => katNumarasi;
            set => katNumarasi = value;
        }

        public string Semti
        {
            get => semti;
            set => semti = value;
        }

        public double Alani
        {
            get => alani;
            set => alani = value;
        }

        public int YapimTarihi
        {
            get => yapimTarihi;
            set => yapimTarihi = value;
        }

        public EmlakTuru Turu
        {
            get => turu;
            set => turu = value;
        }

        public bool Aktif
        {
            get => aktif;
            set => aktif = value;
        }

        public double Fiyat
        {
            get => fiyat;
            set => fiyat = value;
        }

        public double Kira
        {
            get => kira;
            set => kira = value;
        }

        public double Depozito
        {
            get => depozito;
            set => depozito = value;
        }

        public int EmlakNumarasi => emlakNumarasi;  // must be read only i guess bc its unique id


        #endregion


        #region Methods


        public virtual string EvBilgileri()
        {

            return string.Format("Emlak Numarası: {0}\nTürü: {1}\nOda Sayısı: {2}\nKat Numarası: {3}\nSemti: {4}\nAlanı: {5} m²\nYapım Tarihi: {6}\nAktif Durum: {7}",
                     EmlakNumarasi, Turu, OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi, Aktif ? "Aktif" : "Arşivde");
        }


        public double FiyatHesapla()
        {
            double katsayi;

            try
            {
                string path = "oda_ucreti.txt";
                if(File.Exists(path))
                {
                    katsayi = double.Parse(File.ReadAllText(path));
                }
                else
                {
                    katsayi = 200;
                }
            }
            catch
            {
                katsayi = 200;
            }

            return odaSayisi * katsayi;
        }






        #endregion
    }







}
