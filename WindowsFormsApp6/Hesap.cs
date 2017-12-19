using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Hesap
    {
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
        }

        public void ParaCek(decimal m)
        {
            if (hesaptakiPara - m > 0)
                hesaptakiPara -= m;
        }

    }
}
