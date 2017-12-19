using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Banka
    {
        public List<Müsteri> müsteriList = new List<Müsteri>();

        public int müsteriSayisi { get; set; }

        public Banka()
        {
            müsteriSayisi = 0;
        }

        public void MüsteriEkle()
        {
            müsteriSayisi++;
            Müsteri m = new Müsteri(100000 + müsteriSayisi);
            müsteriList.Add(m);
        }

        public void Havale(Hesap ana, Hesap hedef, decimal m)
        {
            int anaIndex = MüsteriIndexBul(ana);
            int hedefIndex = MüsteriIndexBul(hedef);

            if ( (float)müsteriList[anaIndex].MüsteriToplamParası() > 
                   (float) m+ (float)m * müsteriList[anaIndex].HAVALEKATSAYISI )
            {
                müsteriList[anaIndex].hesapList[müsteriList[anaIndex].HesapIndexBul(ana)].
                    ParaCek(m + Convert.ToDecimal((float)m *
                        (float)müsteriList[anaIndex].HAVALEKATSAYISI));

                müsteriList[hedefIndex].hesapList[müsteriList[hedefIndex].HesapIndexBul(hedef)].
                    ParaEkle(m);
            }

        }

        private int MüsteriIndexBul(Hesap h)
        {
            int index = 0;
            int müsteriNo;

            müsteriNo =(h.hesapNo -h.hesapNo % 100)/100;
            foreach (Müsteri m in müsteriList)
            {
                if (m.müsteriNo == müsteriNo)
                    break;
                index++;
            }
            return index;
        }
    }
}
