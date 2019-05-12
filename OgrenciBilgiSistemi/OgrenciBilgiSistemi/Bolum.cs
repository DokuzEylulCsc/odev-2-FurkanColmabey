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
       

        public string GetBolumadı()
        {
            return GetBolumadı();
        }
        public void SetBolumadı(string value)
        {
            SetBolumadı(value);
        }

        public void DersEkle(Ders dersler)
        {
           
        }
        
    }
}
