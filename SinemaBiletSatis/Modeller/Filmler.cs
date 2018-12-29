using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis.Modeller
{
    class Filmler
    {
        private string id;
        private string filmAdi;
        private string afis;
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;

        public Filmler()
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
        public string FilmAdi
        {
            get
            {
                return filmAdi;
            }
            set
            {
                filmAdi = value;
            }
        }
        public string Afis
        {
            get
            {
                return afis;
            }
            set
            {
                afis = value;
            }
        }
        public DateTime BaslangicTarihi
        {
            get
            {
                return baslangicTarihi;
            }
            set
            {
                baslangicTarihi = value;
            }
        }
        public DateTime BitisTarihi
        {
            get
            {
                return bitisTarihi;
            }
            set
            {
                bitisTarihi = value;
            }
        }
    }
}
