using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis.Modeller
{
    class Bilet
    {
        public int id;
        public DateTime satisTarihi;
        public String durum;
        public String izleyiciAd;
        public String izleyiciSoyad;
        public String odemtur;
        public int kullanicid;
        public int koltukid;
        public int seansid;
        public int salonid;
        public int ucretid;
        public int fid;
        public DateTime filmgun;
        public int kisiucreti;

        public int biletId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public DateTime biletSatisTarihi
        {
            get
            {
                return satisTarihi;
            }
            set
            {
                satisTarihi = value;
            }
        }
        public String biletDurumu
        {
            get
            {
                return durum;
            }
            set
            {
                durum = value;
            }
        }
        public String seyirciAd
        {
            get
            {
                return izleyiciAd;
            }
            set
            {
                izleyiciAd = value;
            }

        }
        public String seyirciSoyad
        {
            get
            {
                return izleyiciSoyad;
            }
            set
            {
                izleyiciSoyad = value;
            }
        }
        public String odemeTuru
        {
            get
            {
                return odemtur;
            }
            set
            {
                odemtur = value;
            }
        }
        public int kId
        {
            get
            {
                return kullanicid;
            }
            set
            {
                kullanicid = value;
            }
        }
        public int koltukId
        {
            get { return koltukid; }
            set { koltukid = value; }
        }
        public int seansId
        {
            get { return seansid; }
            set { seansid = value; }
        }
        public int salonId
        {
            get { return salonid; }
            set { salonid = value; }
        }
        public int ucretId
        {
            get { return ucretid; }
            set { ucretid = value; }
        }
        public int fId
        {
            get { return fid; }
            set { fid = value; }
        }
        public DateTime filmGun
        {
            get { return filmgun; }
            set { filmgun = value; }
        }
        public int kisiUcreti
        {
            get { return kisiucreti; }
            set { kisiucreti = value; }
        }

    }
}