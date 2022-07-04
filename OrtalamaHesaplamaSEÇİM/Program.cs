using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplamaSEÇİM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        BASADON:
            Console.Clear();
            Console.Write("1.Yazılı notunu giriniz");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Yazılı notunu giriniz");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.Yazılı notunu giriniz");
            int y3 = Convert.ToInt32(Console.ReadLine());

            int ort = (y1+ y2 + y3) / 3 ;
            Console.WriteLine("ORTALAMA: {0}",ort);

        SEÇİMYAP:
            Console.Write("yeniden işlem yapmak ister misiniz (evet için e, hayır için h ye basınız)");
            char secım = Convert.ToChar(Console.ReadLine());
            if (secım== 'e'||secım=='E')
            {
                goto BASADON;
            }
            else if (secım == 'h' || secım == 'H')
            {
                Console.WriteLine("iyi günler");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış seçim yaptınız.Tekarar deneyiniz(evet için e, hayır için h) ");
                goto SEÇİMYAP;
            }
            Console.ReadLine();
        }
    }
}
