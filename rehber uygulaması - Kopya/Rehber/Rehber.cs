using System;
using System.Collections.Generic;

namespace vscode_deneme
{
    public class MainBlock
    {
        public void MainBlockF()
        {
            List<string> AdSoyadList = new List<string>();
            AdSoyadList.Add("Ali Mert");
            AdSoyadList.Add("Mehmet Tunç");
            AdSoyadList.Add("Aslı Şen");
            AdSoyadList.Add("Melike Soy");
            AdSoyadList.Add("Mert Kaplan");
            
            List<string> NumaraList = new List<string>();
            NumaraList.Add("05384566237");
            NumaraList.Add("05374519853");
            NumaraList.Add("05335647891");
            NumaraList.Add("05327891265");
            NumaraList.Add("05123579516");

            YapilacakIslem islem = new YapilacakIslem();
            int sayi = islem.YapilacakIslemF();
            switch (sayi)
            {
                case 1:
                {
                    NumaraKaydet kayit = new NumaraKaydet();
                    kayit.NumaraKaydetF(AdSoyadList,NumaraList);
                    break;
                }
                case 2:
                {
                    NumaraSilmek sil = new NumaraSilmek();
                    sil.NumaraSilmekF(AdSoyadList,NumaraList);
                    break;
                }
                case 3:
                {
                    NumaraGuncellemek guncelle = new NumaraGuncellemek();
                    guncelle.NumaraGuncellemekF(AdSoyadList,NumaraList);
                    break;
                }
                case 4:
                {
                    RehberListeleme listele = new RehberListeleme();
                    listele.RehberListelemeF(AdSoyadList,NumaraList);
                    break;
                }
                case 5:
                {
                    RehberdeArama arama = new RehberdeArama();
                    arama.RehberdeAramaF(AdSoyadList,NumaraList);
                    break;
                }
                case 6:
                {
                    Program kapa = new Program();
                    kapa.ProgramKapat();
                    break;
                }
                default:
                {
                    Console.WriteLine("***************** HATA *******************");
                    Console.WriteLine("Hatalı tuşlama yaptınız! Tekrar deneyiniz!");
                    Console.WriteLine("***************** HATA *******************");
                    islem.YapilacakIslemF();
                    break;
                }
            }
        }
    }
}