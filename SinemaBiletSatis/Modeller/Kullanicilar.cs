using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SinemaBiletSatis.Modeller
{
    class Kullanicilar
    {
        private string id;
        private string tc;
        private string adi;
        private string soyadi;
        private string email;
        private string parola;
        private int yetki;

        public Kullanicilar()
        {          
        }
        public string Id
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
        public string Tc
        {
            get
            {
                return tc;
            }
            set
            {
                tc = value;
            }
        }
        public string Adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi = value;
            }
        }
        public string Soyadi
        {
            get
            {
                return soyadi;
            }
            set
            {
                soyadi = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Parola
        {
            get
            {
                return parola;
            }
            set
            {
                parola = value;
            }
        }
        public int Yetki
        {
            get
            {
                return yetki;
            }
            set
            {
                yetki = value;
            }
        }
    }
}
