using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
     class Bolum
    {
        public List<Ders> dersler = new List<Ders>();
        private string BolumAdı;
        private string ders;
        public Bolum(string ad)
        {
            BolumAdı = ad;
        }
       
       public string bolumAdi
        {
            get
            {
                return BolumAdı;
            }
        }
        public string Ders
        {
            get
            {
                return ders;
            }
        }

        public void DersEkle(Ders dersler)
        {
          
        }
        public void DersSil(Ders dersler)
        {

        }
    }
}
