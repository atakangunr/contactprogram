using System;
using System.Collections.Generic;

namespace vscode_deneme
{
    public class NumaraGuncellemek
    {
                public void NumaraGuncellemekF(List<string> liste1, List<string> liste2)
        {
            Console.WriteLine("Lütfen numarası güncellenecek kişinin ismini ve soyismini giriniz: ");
            string GuncellenecekKisi = Console.ReadLine();
                
            if (GuncellenecekKisi == "close" || GuncellenecekKisi == "kapat")
                {
                    Program kapa = new Program();
                    kapa.ProgramKapat();
                }

            else 
            {
                if(liste1.Contains(GuncellenecekKisi))
                {
                    int i = liste1.BinarySearch(GuncellenecekKisi);
                    liste2.RemoveAt(i);
                    liste1.RemoveAt(i);
                    liste1.Add(GuncellenecekKisi);
                    Console.Write("Yeni numarayı giriniz: ");
                    liste2.Add(Console.ReadLine());

                    YapilacakIslem islem = new YapilacakIslem();
                    islem.YapilacakIslemF();
                }
                else
                {
                    Console.WriteLine("************************ HATA *************************");
                    Console.WriteLine("Aradığınız kişi listede mevcut değil! Tekrar deneyiniz!");
                    Console.WriteLine("************************ HATA *************************");
                    NumaraGuncellemekF(liste1, liste2);
                }
            }
        }
    }
}