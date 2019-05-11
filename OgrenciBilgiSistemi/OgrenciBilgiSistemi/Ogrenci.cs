using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
     abstract class Ogrenci
    {
        private int OgrenciNo;
        private string OgrenciAd;
        private string OgrenciBolum;

        public Ogrenci(int no,string ad,string bolum)
        {
            OgrenciNo = no;
            OgrenciAd = ad;
            OgrenciBolum = bolum;
        }

        public int OgrenciNo
        {
            get => OgrenciNo;
            set => OgrenciNo = value;
        }
        public string OgrenciAd
        {
            get => OgrenciAd;
            set => OgrenciAd = value;
        }
        public string OgrenciBolum
            {
            get => OgrenciBolum;
            set => OgrenciBolum = value;
            }
        
    }
}
