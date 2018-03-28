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

        public void MüsteriEkle(string ad,string soyad,double TC,string Tür)
        {
            müsteriSayisi++;
            if (Tür == "Bireysel Müşteri")
            {
                Müsteri m = new BireyselMüsteri(100000 + müsteriSayisi);
                m.KisiBilgiEkle(ad, soyad, TC);
                müsteriList.Add(m);
            }
            else if(Tür== "Ticari Müşteri")
            {
                Müsteri m = new TicariMüsteri(100000 + müsteriSayisi);
                m.KisiBilgiEkle(ad, soyad, TC);
                müsteriList.Add(m);
            }
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

        private byte MüsteriIndexBul(Hesap h)
        {
            byte index = 0;
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

        public  byte MüsteriIndexBulH(int hesapNo)
        {
            byte index = 0;
            int müsteriNo;

            müsteriNo = (hesapNo - hesapNo % 100) / 100;
            foreach (Müsteri m in müsteriList)
            {
                if (m.müsteriNo == müsteriNo)
                    break;
                index++;
            }
            return index;
        }

        public byte MüsteriIndexBul(int müsteriNo)
        {
            byte index = 0;
            
            foreach (Müsteri m in müsteriList)
            {
                if (m.müsteriNo == müsteriNo)
                    break;
                index++;
            }
            return index;
        }

        public List<GelirGider> Gelir_GiderOzetListesi()
        {
            List<GelirGider> list = new List<GelirGider>();

            GelirGider g;

            foreach (Müsteri m in müsteriList)
            {
                g = new GelirGider(m);
                list.Add(g);
            }
            return list;
        }


    }
}
