using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Müsteri : Kisi
    {
        protected const decimal GUNLUKLIMIT = 750;
        public float HAVALEKATSAYISI;

        public decimal kalanLimit{ get;  set; }
        public decimal cekilenPara { get; set; }

        public List<Hesap> hesapList;
        Hesap hesap;

        protected DateTime ilkCekildigiTarih;

        public int müsteriNo { get; protected set; }
        protected byte hesapSayisi { get; set; }            
        protected byte maxHesapSayisi { get;  set; }
        public string müsteriTürü { get; protected set; }
       
        public Müsteri()
        {
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            ilkCekildigiTarih = DateTime.Now.Date;
            kalanLimit = GUNLUKLIMIT;
            cekilenPara = 0;
        }

        public Müsteri(int müsteriNo)
        {
            hesapSayisi = 0;
            maxHesapSayisi = 20;
            this.müsteriNo = müsteriNo;
            ilkCekildigiTarih = DateTime.Now.Date;
            kalanLimit = GUNLUKLIMIT;
            cekilenPara = 0;

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

            if(ilkCekildigiTarih!=DateTime.Now.Date)
            {
                kalanLimit = GUNLUKLIMIT;
                ilkCekildigiTarih = DateTime.Now.Date;
            }

            if(hesapList[index].hesaptakiPara-m>0 && kalanLimit >= m)
            {
                kalanLimit -= m;
                hesapList[index].ParaCek(m);
                cekilenPara += m;
            }

            else if(MüsteriToplamParası()-m> 0 && kalanLimit >= m )
            {
                kalanLimit -= m;
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
                cekilenPara += m;
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
        public byte HesapIndexBul(int no)
        {
            byte index = 0;
            foreach (Hesap k in hesapList)
            {
                if (no == k.hesapNo)
                    break;
                index++;
            }
            return index;
        }


    }
}
