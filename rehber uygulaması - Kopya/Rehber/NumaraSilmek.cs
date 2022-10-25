using System;
using System.Collections.Generic;

namespace vscode_deneme
{
    public class NumaraSilmek
    {
        public void NumaraSilmekF(List<string> liste1, List<string> liste2)
        {
            Console.WriteLine("Lütfen silinecek kisinin ismini ve soyismini giriniz: ");
            string SilinecekKisi = Console.ReadLine();
                
            if (SilinecekKisi == "close" || SilinecekKisi == "kapat")
                {
                    Program kapa = new Program();
                    kapa.ProgramKapat();
                }

            else 
            {
                if (liste1.Contains(SilinecekKisi))
                {
                    int binary = liste1.BinarySearch(SilinecekKisi);
                    liste1.RemoveAt(binary);
                    liste2.RemoveAt(binary);
                    Console.WriteLine("Kişi rehberden silinmiştir.");

                    YapilacakIslem islem = new YapilacakIslem();
                    islem.YapilacakIslemF();
                }
                else
                {
                    Console.WriteLine("************************ HATA *************************");
                    Console.WriteLine("Aradığınız kişi listede mevcut değil! Tekrar deneyiniz!");
                    Console.WriteLine("************************ HATA *************************");
                    NumaraSilmekF(liste1, liste2);
                }
            }

        }
    }
}