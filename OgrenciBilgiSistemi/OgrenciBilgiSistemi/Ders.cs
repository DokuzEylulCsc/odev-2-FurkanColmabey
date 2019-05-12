using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Ders
    {
        public List<Ogrenci> BolumOgrencileri = new List<Ogrenci>();
        private int DersKodu;
        private string DersAdı;
        private readonly int index;

        public Ders(string DersAdı,int DersKodu)
        {
            this.DersAdı = DersAdı;
            this.DersKodu = DersKodu;
        }
            
        public int dersKodu
        {
            get
            {
                return DersKodu;
            }
            set
            {
                DersKodu = value;
            }
        }
        public string dersAdı
        {
            get
            {
                return DersAdı;
            }
            set
            {
                DersAdı = value;
            }
        }
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            BolumOgrencileri.Add(ogrenci);
        }
         public void OgrenciCikar(Ogrenci ogrenci)
        {
            BolumOgrencileri.RemoveAt(index);
        }
    }
}
