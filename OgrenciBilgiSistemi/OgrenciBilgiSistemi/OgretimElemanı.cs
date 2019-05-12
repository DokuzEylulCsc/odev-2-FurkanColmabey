using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
     class OgretimElemanı
    {
        private string ad;
        private string bolum;

        public OgretimElemanı(string ad,string bolum)
        {
            this.bolum = bolum;
            this.ad = ad;
        }
        public string OgretimElemaniAd
        {
            get
            {
                return ad;
            }
           
        }
        public string OgretimElemanibolum
        {
            get
            {
                return bolum;
            }
            
        }
    }
}
