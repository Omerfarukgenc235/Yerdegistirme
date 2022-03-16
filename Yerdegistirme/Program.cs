using System;
using System.Collections.Generic;
namespace Yerdegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            char[] alfabe2 = { 'O', 'K', 'H', 'J', 'B', 'N', 'L', 'P', 'Ö', 'A', 'T', 'G', 'U', 'Ş', 'Y', 'Ü', 'Ç', 'D', 'F', 'C', 'İ', 'Ğ', 'V', 'E', 'S', 'M', 'I', 'Z', 'R' };
            string mesaj;
            Console.WriteLine("Lütfen mesajınızı giriniz");
            mesaj = Console.ReadLine();
            mesaj = mesaj.ToUpper();
            char[] mesajharfleri = mesaj.ToCharArray();
            List<int> cevirilecekharflerinsayilari = new List<int>();
            int sayisi = 0;
            foreach (var y in mesajharfleri)
            {
                foreach (var x in alfabe)
                {
                    if (x == y)
                    {
                        cevirilecekharflerinsayilari.Add(sayisi);
                    }
                    else
                    {
                        sayisi++;
                    }
                }
                sayisi = 0;
            }
            List<char> geridondurmekicinkarakter = new List<char>();
            foreach (var x in cevirilecekharflerinsayilari)
            {
                geridondurmekicinkarakter.Add(alfabe2[x]);
            }
            Console.Write("Yer değiştirme algoritmasına göre şifrelenmiş hali = ");
            foreach (var x in geridondurmekicinkarakter)
            {
                Console.Write(x);
            }
            Console.WriteLine("");
            List<int> gericevirilecekharflerinsayilari = new List<int>();
            int sayisi2 = 0;
            foreach (var y in geridondurmekicinkarakter)
            {
                foreach (var x in alfabe2)
                {
                    if (x == y)
                    {
                        gericevirilecekharflerinsayilari.Add(sayisi2);
                    }
                    else
                    {
                        sayisi2++;
                    }
                }
                sayisi2 = 0;
            }
            List<char> cozulmuskarakter = new List<char>();
            foreach (var x in gericevirilecekharflerinsayilari)
            {
                cozulmuskarakter.Add(alfabe[x]);
            }
            Console.Write("Çözülmüş hali = ");
            foreach (var x in cozulmuskarakter)
            {
                Console.Write(x);
            }
        }
    }
}