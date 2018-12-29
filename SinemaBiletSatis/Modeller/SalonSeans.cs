using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis.Modeller
{
    class SalonSeans
    {
        private string id;
        private int filmID;
        private int seansID;
        private int salonID;

        public SalonSeans()
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
        
        public int FilmID
        {
            get
            {
                return filmID;
            }
            set
            {
                filmID = value;
            }
        }
        public int SeansID
        {
            get
            {
                return seansID;
            }
            set
            {
                seansID = value;
            }
        }
        public int SalonID
        {
            get
            {
                return salonID;
            }
            set
            {
                salonID = value;
            }
        }
    }
}
