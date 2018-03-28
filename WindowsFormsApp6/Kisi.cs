using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public abstract class Kisi
    {
        public string ad { get; private set; }
        public string soyad { get; private set; }
        public double tc { get; private set; }
        public Kisi()
        {

        }
        public Kisi(string ad,string soyad,double tc)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.tc = tc;
        }
        public void KisiBilgiEkle(string ad, string soyad, double tc)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.tc = tc;
        }
    }
}
