using System;
using System.Collections.Generic;

namespace vscode_deneme
{
    public class RehberdeArama
    {
        public void RehberdeAramaF(List<string> liste1, List<string> liste2)
        {
            Console.WriteLine("İsim ve soyisme göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            Console.WriteLine("***************************************");
            Console.Write("Arama yapmak istediğiniz tipi seçiniz: ");
            int tip = Convert.ToInt16(Console.ReadLine());
            
            Program kapa = new Program();
                        
            switch (tip)
            {
                case 1:
                {
                    Console.Write("Arama yapacağınız kişinin isim ve soyismini giriniz: ");
                    string aranankisi = Console.ReadLine();

                    if (aranankisi == "close" || aranankisi == "kapat")
                        kapa.ProgramKapat();
                        
                    else
                    {
                        if (liste1.Contains(aranankisi))
                        {
                            Console.WriteLine("Aradığınız kişi listede mevcut!");
                            int indeks1 = liste1.BinarySearch(aranankisi);
                            Console.WriteLine("İsmi ve Soyismi: " + liste1[indeks1]);
                            Console.WriteLine("Numarası: " + liste2[indeks1]);
    
                            YapilacakIslem islem = new YapilacakIslem();
                            islem.YapilacakIslemF();
                        }
                        else
                        {
                            Console.WriteLine("************************ HATA *************************");
                            Console.WriteLine("Aradığınız kişi listede mevcut değil! Tekrar deneyiniz!");
                            Console.WriteLine("************************ HATA *************************");
                            RehberdeAramaF(liste1,liste2);
                        }
                    }
                    break;
                }
                case 2:
                {
                    Console.Write("Arama yapacağınız kişinin numarasını giriniz: ");
                    string aranannumara = Console.ReadLine();
                        
                    if (aranannumara == "close" || aranannumara == "kapat")
                        kapa.ProgramKapat();

                    else
                    {
                        if (liste2.Contains(aranannumara))
                        {
                            Console.WriteLine("Aradığınız numara listede mevcut!");
                            int indeks2 = liste2.BinarySearch(aranannumara);
                            Console.WriteLine("İsmi ve Soyismi: " + liste1[indeks2]);
                            Console.WriteLine("Numarası: " + liste2[indeks2]);

                            YapilacakIslem islem = new YapilacakIslem();
                            islem.YapilacakIslemF();
                        }
                        else
                        {
                            Console.WriteLine("************************* HATA **************************");
                            Console.WriteLine("Aradığınız numara listede mevcut değil! Tekrar deneyiniz!");
                            Console.WriteLine("************************* HATA **************************");
                            RehberdeAramaF(liste1,liste2);
                        }
                    }
                    break;
                }
                default:
                {
                    Console.WriteLine("***************** HATA *******************");
                    Console.WriteLine("Hatalı tuşlama yaptınız! Tekrar deneyiniz!");
                    Console.WriteLine("***************** HATA *******************");
                    RehberdeAramaF(liste1,liste2);
                    break;
                }
            }
        }
    }
}