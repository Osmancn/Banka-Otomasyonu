using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class HespOzeti
    {
        public DateTime islemTarihi { get; private set; }

        public decimal islemYapilanPara { get; private set; }

        public HespOzeti(DateTime z, decimal m)
        {
            islemTarihi = z;
            islemYapilanPara = m;
        }
    }
}
