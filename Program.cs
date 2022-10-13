using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bDevam;
            do
            {
                char karakter;
                string toplam = "", szCevap;
                uint kacKere;
                bDevam = false;
                Console.Write("LÜTFEN TEK BİR KARAKTER GİRİNİZ: ");
                karakter = Char.Parse(Console.ReadLine());
                Console.Write("LÜTFEN KAÇ KERE GİRİLECEĞİNİ YAZINIZ: ");
                kacKere = uint.Parse(Console.ReadLine());
                for (int i = 0; i < kacKere; i++)
                {
                    toplam += karakter;
                    Console.WriteLine(toplam);
                }
                Console.Write("\nDevam etmek istiyor musunuz? (E/H)");
                szCevap = Console.ReadLine();
                if (szCevap == "h" || szCevap == "H") bDevam = true;
                else
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            } while (bDevam == false);
            }
    }
}
