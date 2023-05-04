namespace Loops.Returns_;

public static class Program
{
    //public static int sonuc = 0;
    //public static void Hesapla(int s1, int s2)
    //{
    //    sonuc = s1 + s2;
    //}


    public static int Hesapla(int s1, int s2)
    {
        int toplam = s1 + s2;
        return toplam;
    }

    // dışarıdan kullanıcının adını, soyadını ve domain (hotmail.com) adını alan bir  metot yazınız.
    // tüm harfler küçük olarak çevrilip özel karakterleri barındırmayacak ve, kullanıcı domain adı vermezse default bir domain adı belirleyiniz. kullanıcıya mail adresi teslim ediniz.



    public static string Mail(string isim, string soyisim, string? domain = "code.edu.az")
    {
        //if (string.IsNullOrWhiteSpace(domain)) 
        //    domain = "hotmail.com";

        string mail = $"{isim}.{soyisim}@{domain}"
               .ToLower()
               .Replace("?", "")
               .Replace("*", "")
               .Replace("+", "")
               .Replace("$", "");

        return mail;
    }



    //Disaridan bir int[] dizisinin parametre olarak alan bir metot yaziniz. Metot, parametredeki dizide yer alan elemanlarin toplaminin karekökünü dondursun... (ONDALIKLI GELEBILIR!)


    public static double DiziCalculate(int[] dizi)
    {
        #region Örnek
        //int toplam = 0;
        //for (int i = 0; i < dizi.Length; i++)
        //{
        //    toplam += dizi[i];
        //}

        //foreach (int sayi in dizi)
        //{
        //    toplam += sayi;
        //} 
        #endregion 

        int toplam = Enumerable.Sum(dizi);
        return Math.Sqrt(toplam);

    }


    // Dışarıdan girilen değerin, çift ise = -1, tek ise = 1, 0'a eşit ise = 0 değerini teslim eden metot yazınız.



    public static int TekCiftKontrolu(int sayi)
    {
        if (sayi == 0)
        {
            return 0;
        }
        else if (sayi % 2 == 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    public static void Main(String[] args)
    {
        //int sonuc = Hesapla(20, 40);
        //Console.WriteLine("Hesaplama İşlemi sonucu, " + sonuc);

        //string isim = "Murat";
        //string soyisim = "VURANOK";
        //string domain = "COdegame.Edu.AZ";

        //string mail = Mail(isim, soyisim);
        //Console.WriteLine(mail);

        //mail = Mail(isim, soyisim, domain);
        //Console.WriteLine(mail);


        //var result = DiziCalculate(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
        //Console.WriteLine(result);


        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
            var result = TekCiftKontrolu(sayi);
            Console.WriteLine(result);
        }

    }
}