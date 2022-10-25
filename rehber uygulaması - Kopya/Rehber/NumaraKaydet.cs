using System;
using System.Collections.Generic;

namespace vscode_deneme
{
    public class NumaraKaydet
    {
        public void NumaraKaydetF(List<string> liste1, List<string> liste2)
        {
            Console.Write("Kaydedilecek kişinin ismini soyismini giriniz: ");
            string isimsoyisim = Console.ReadLine();
            
            if (isimsoyisim == "close" || isimsoyisim == "kapat")
                {
                    Program kapa = new Program();
                    kapa.ProgramKapat();
                }
            
            else 
            {
                Console.Write("Numarayı giriniz: ");
                string numara = Console.ReadLine();

                liste1.Add(isimsoyisim);
                liste2.Add(numara);

                Console.WriteLine("Numara Kaydedilmiştir.");

                YapilacakIslem islem = new YapilacakIslem();
                islem.YapilacakIslemF();
            }
        }
    }
}