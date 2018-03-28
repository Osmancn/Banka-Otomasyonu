using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class TicariMüsteri:Müsteri
    {
        public new const float HAVALEKATSAYISI = 0;

        public TicariMüsteri()
        {
            müsteriTürü = "Ticari Müşteri";
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            ilkCekildigiTarih = DateTime.Now.Date;
            kalanLimit = GUNLUKLIMIT;
            cekilenPara = 0;
        }
        public TicariMüsteri(int müsteriNo)
        {
            müsteriTürü = "Ticari Müşteri";
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            this.müsteriNo = müsteriNo;
            ilkCekildigiTarih = DateTime.Now.Date;
            kalanLimit = GUNLUKLIMIT;
            cekilenPara = 0;
        }
    }
}
