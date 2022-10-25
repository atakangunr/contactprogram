using System;

namespace vscode_deneme
{
    public class TelefonSifresi
    {
        void SifreAlma()
        {
            const int Sifre = 1234;
            int GirilenSifre;
            Console.WriteLine("Telefon Sifresini Giriniz: ");
            for (int sayac = 0; sayac < 4; sayac++ )
            {
                Console.ReadLine(Convert.ToInt16(GirilenSifre));
                if (GirilenSifre == Sifre)
                {
                    Console.WriteLine("Şifre Doğru!");
                    Console.WriteLine("Yönlendiriliyorsunuz...");
                    break;
                }
                else
                {
                    int hak=3;
                    Console.WriteLine("Hatalı şifre girdiniz!!");
                    Console.WriteLine("{0} Hakkınız kaldı.",hak);
                    hak--;

                    
                }
            }

        }
    }
}