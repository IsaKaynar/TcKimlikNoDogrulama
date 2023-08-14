using System;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main()
    {

        //TC Kimlik numaraları 11 basamaktan oluşmaktadır. İlk 9 basamak arasında kurulan bir algoritma bize 10.basmağı, ilk 10 basamak arasında kurulan algoritma ise bize 11.basamağı verir.
        //11 hanelidir.
        //Her hanesi rakamsal değer içerir.
        //İlk hane 0 olamaz.
        //1. 3. 5. 7.ve 9.hanelerin toplamının 7 katından, 2. 4. 6.ve 8.hanelerin toplamı çıkartıldığında, elde edilen sonucun 10′a bölümünden kalan, yani Mod10′u bize 10.haneyi verir.
        //1. 2. 3. 4. 5. 6. 7. 8. 9.ve 10.hanelerin toplamından elde edilen sonucun 10′a bölümünden kalan, yani Mod10′u bize 11.haneyi verir.

        Console.Write("TC kimlik numaranızı giriniz: ");
        string tc = Console.ReadLine();
        Console.WriteLine("'" + tc + "' bilgisi sonucu: " + TcDogrula(tc));
    }
    

    static bool TcDogrula(string tc)
    {

        bool sonuc = false;
        int tekSayiTopla = 0;
        int ciftSayiTopla = 0;
        int tumSayilariTopla = 0;
        for (int i = 0; i < tc.Length - 1; i = i + 2)
        {
            tekSayiTopla += Convert.ToInt32((int)Char.GetNumericValue(tc[i]));
        }
        for (int i = 1; i < tc.Length - 2; i = i + 2)
        {
            ciftSayiTopla += Convert.ToInt32((int)Char.GetNumericValue(tc[i]));
        }
        int onuncubasamakSonuc = ((tekSayiTopla * 7) - ciftSayiTopla) % 10;

        for (int i = 0; i < tc.Length - 1; i++)
        {
            tumSayilariTopla += Convert.ToInt32((int)Char.GetNumericValue(tc[i]));
        }
        int onBirsonuc = tumSayilariTopla % 10;

        if (onuncubasamakSonuc == Convert.ToInt32((int)Char.GetNumericValue(tc[9])))
        {
            if (onBirsonuc == Convert.ToInt32((int)Char.GetNumericValue(tc[10])))
            {
                sonuc = true;
            }
        }
        return sonuc;
    }

}