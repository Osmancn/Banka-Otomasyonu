using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class BireyselMüsteri:Müsteri
    {
        public new const float HAVALEKATSAYISI = 2 / 100;

        public BireyselMüsteri()
        {
            müsteriTürü = "Bireysel Müşteri";
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            ilkCekildigiTarih = DateTime.Now.Date;
            kalanLimit = GUNLUKLIMIT;
            cekilenPara = 0;
        }
        public BireyselMüsteri(int müsteriNo)
        {
            müsteriTürü = "Bireysel Müşteri";
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            this.müsteriNo = müsteriNo;
            ilkCekildigiTarih = DateTime.Now.Date;
            kalanLimit = GUNLUKLIMIT;
            cekilenPara = 0;
        }
    }
}
