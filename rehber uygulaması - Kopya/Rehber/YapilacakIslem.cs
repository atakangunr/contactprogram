using System;

namespace vscode_deneme
{
    public class YapilacakIslem
    {
        public int YapilacakIslemF()
        {
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek.");
            Console.WriteLine("(2) Varolan Numarayı Silmek.");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek.");
            Console.WriteLine("(4) Rehberi Listelemek.");
            Console.WriteLine("(5) Rehberde Arama Yapmak.");
            Console.WriteLine("(6) Programı Kapatmak.(Programın herhangi bir yerinde close/kapat yazabilirsiniz.)");
            Console.WriteLine("********************************");
            Console.Write("Lütfen yapılacak işlemi seçiniz: ");
            int yapilacakislem = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            return yapilacakislem;
        }
    }
}