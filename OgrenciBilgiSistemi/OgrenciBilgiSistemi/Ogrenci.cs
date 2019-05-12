using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
     abstract class Ogrenci
    {
        private int no;
        private string ad;
        private string bolum;

        public Ogrenci(int no,string ad,string bolum)
        {
            this.no = no;
            this.ad = ad;
            this.bolum = bolum;
        }

        public int No
        {
            get => no;
        }
        public string Ad
        {
            get => ad;
        }
        public string Bolum
            {
            get => bolum;
            }
        
    }
}
