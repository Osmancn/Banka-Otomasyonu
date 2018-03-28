using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class GelirGider
  {
        Müsteri m = new Müsteri();

        public int müsteriNo { get; set; }
        public decimal toplamPara { get; set; } 
        public decimal cekilenPara { get; set; } 
        public decimal yatirilanPara { get; set; }
        

        public GelirGider(Müsteri m)
        {
            this.m = m;
            müsteriNo = m.müsteriNo;
            toplamPara = m.MüsteriToplamParası();
            cekilenPara = m.cekilenPara;
            yatirilanPara = toplamPara + cekilenPara;
        }
    }
}
