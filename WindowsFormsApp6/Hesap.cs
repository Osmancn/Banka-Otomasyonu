using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Hesap
    {
        public List<HespOzeti> hesapozeti = new List<HespOzeti>();

        public HespOzeti hO;

        public DateTime islemTarihi { get; private set; }
        public int hesapNo { get; private set; }  
        
        public decimal hesaptakiPara { get; set; }   

        public Hesap(int hesapNo)
        {
            this.hesapNo = hesapNo;
            hesaptakiPara = 0;
        }

        public void ParaEkle(decimal m)
        {
            hesaptakiPara += m;
            islemTarihi = DateTime.Now;
            hO = new HespOzeti(islemTarihi, m);
            hesapozeti.Add(hO);

        }

        public void ParaCek(decimal m)
        {

            if (hesaptakiPara - m > 0)
            {
                hesaptakiPara -= m;
                islemTarihi = DateTime.Now;
                hO = new HespOzeti(islemTarihi, -m);
                hesapozeti.Add(hO);
            }

        }

    }
}
