using System;
using System.Collections.Generic;

namespace vscode_deneme
{
    public class RehberListeleme
    {
        public void RehberListelemeF(List<string> liste1, List<string> liste2)
        {
            int n = 0;
            foreach (string adsoyad in liste1)
            {
                Console.WriteLine(adsoyad);
                Console.WriteLine(liste2[n]);
                n++;
            }

            YapilacakIslem islem = new YapilacakIslem();
            islem.YapilacakIslemF();
        }
    }
}