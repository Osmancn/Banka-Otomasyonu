using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Müsteri : Kisi
    {
        private const short GUNLUKLIMIT = 750;

        public List<Hesap> hesapList;
        Hesap hesap;


        public int müsteriNo { get; private set; }
        public byte hesapSayisi { get; protected set; }
        public byte maxHesapSayisi { get; protected set; }
        public string müsteriTürü { get; protected set; }
        public float HAVALEKATSAYISI;
        
        public Müsteri()
        {
            hesapSayisi = 0;
            maxHesapSayisi = 20;
        }

        public Müsteri(int müsteriNo)
        {
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            this.müsteriNo = müsteriNo;
        }

        public void MüsteriNoEkle(int müsteriNo)
        {
            this.müsteriNo = müsteriNo;
        }

        public void HesapAc()
        {
            if (hesapList == null)
            {
                hesapList = new List<Hesap>();
            }
            if(hesapSayisi<maxHesapSayisi)
            {
                hesapSayisi++;
                hesap = new Hesap(müsteriNo * 100 + (hesapSayisi));
                hesapList.Add(hesap);
            }   
        }

        public void HesaptanParaCekme(Hesap h,decimal m)
        { 
            byte index = HesapIndexBul(h);

            if(hesapList[index].hesaptakiPara-m>0)
            {
                hesapList[index].ParaCek(m);
            }

            else if(MüsteriToplamParası()-m>0)
            {
                decimal cekilecekPara = m;
                cekilecekPara -= hesapList[index].hesaptakiPara;
                hesapList[index].ParaCek(hesapList[index].hesaptakiPara);
                foreach (Hesap k in hesapList)
                {
                    if(k.hesaptakiPara-cekilecekPara>0)
                    {
                        k.ParaCek(cekilecekPara);
                        break;
                    }
                    else
                    {
                        cekilecekPara -= k.hesaptakiPara;
                        k.ParaCek(k.hesaptakiPara);
                    }
                }
            }                
        }

        public void HesapKapama(Hesap h)
        {
            decimal hesaptakiPara = h.hesaptakiPara;
            byte index = HesapIndexBul(h);
            if(hesapSayisi>1)
            {
                hesapList[index].ParaCek(hesaptakiPara);
                foreach (Hesap k in hesapList)
                {
                    if(k != h)
                    {
                        k.ParaEkle(hesaptakiPara);
                        break;
                    }
                }
                for(int i = index+1; i < hesapSayisi; i++)
                {
                    hesapList[i - 1] = hesapList[i];
                }
                hesapList.RemoveAt(hesapList.Count-1);//sondakini siler
                maxHesapSayisi++;
            }
            else//1tane hesabı var
            {
                hesapList[0].ParaCek(hesapList[0].hesaptakiPara);
                hesapList.Clear();
                hesapSayisi--;
            }

        }

        public decimal MüsteriToplamParası()
        {
            decimal m=0;
            foreach (Hesap h in hesapList)
            {
                m += h.hesaptakiPara;
            }
            return m;
        }

        public byte HesapIndexBul(Hesap h)
        {
            byte index = 0;
            foreach (Hesap k in hesapList)
            {
                if (h.hesapNo == k.hesapNo)
                    break;
                index++;
            }
            return index;
        }


    }
}
