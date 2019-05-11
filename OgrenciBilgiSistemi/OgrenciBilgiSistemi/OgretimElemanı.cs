using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
     class OgretimElemanı
    {
        private string OgretimElemaniAd;
        private string OgretimElemanibolum;

        public OgretimElemanı(string ad,string bolum)
        {
            OgretimElemanibolum = bolum;
            OgretimElemaniAd = ad;
        }
        public string OgretimElemaniAd
        {
            get
            {
                return OgretimElemaniAd;
            }
            set
            {
                OgretimElemaniAd = value;
            }
        }
        public string OgretimElemanibolum
        {
            get
            {
                return OgretimElemanibolum;
            }
            set
            {
                OgretimElemanibolum = value;
            }
              
        }
    }
}
