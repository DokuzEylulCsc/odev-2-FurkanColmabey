using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
     class Fakülte:Universite
    {
        private string FakulteAd;
        public List<Bolum> bolumler = new List<Bolum>();

        public Fakülte(string FakulteAd)
        {
            this.FakulteAd = FakulteAd;
        }

        public void BolumEkle(Bolum bolum)
        {
            bolumler.Add(bolum);
        }

    }
}
