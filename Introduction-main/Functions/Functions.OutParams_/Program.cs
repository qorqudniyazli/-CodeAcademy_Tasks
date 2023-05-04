namespace Functions.OutParams_;



public static class Program
{


    //public static int sonuc = 0;
    //public static void Hesapla(int s1, int s2)
    //{
    //    int toplam = s1 + s2;
    //    sonuc = toplam;
    //}



    public static void Hesapla(in int s1, in int s2, out int retVal)
    {
        //int toplam = s1 + s2;
        //sonuc = toplam;
        retVal = s1 + s2;
    }



    /* 
     Dışarıdan girilen 2 değerin, toplamını, farkını, çarpım, bolum ve mod değerini dışarıya fırlatan bir metot yazınız :) metot  void olacak :D
     */


    public static void Calculate(int s1, int s2,
        out int toplam,
        out double bolum,
        out long carpim,
        out int fark,
        out int mod)
    {
        bolum = s2 / s1;
        toplam = s1 + s2;
        carpim = s1 * s2;
        fark = s2 - s1;
        mod = s2 % s1;
    }



    // Yukarıda yaptığımız işlemin aynısını return eden bir metot yazınız :)

    public static (
        int Toplam,
        double Bolum,
        long Carpim,
        int Fark,
        int Mod) YukaridakiMetot(int s1, int s2)
    {
        return (
                Toplam: s1 + s2,
                Bolum: s2 / s2,
                Carpim: s1 * s2,
                Fark: s2 - s1,
                Mod: s2 % s1
                );
    }

    public static (bool success, int? result) SaveChange(string data)
    {
        bool success = false;
        int? sayi;

        try
        {
            sayi = int.Parse(data);
            success = true;
        }
        catch (FormatException ex)
        {
            return (success, null);
        }
        return (success, sayi);
    }

    public static bool TrySaveChangeAsyc(string data, out int? sayi)
    {
        try
        {
            sayi = int.Parse(data);
        }
        catch
        {
            sayi = null;
            return false;
        }

        return true;
    }

    //public static bool SaveChangeAsync(out int count)
    //{
    //    //count = _context.SaveChanges();  // eklenen kayıt sayısı 10 
    //    return count > 0;
    //}



    // Metot içerisinde kaç adet parametre geleceği belirsizse, kullanmanız gereken anahtar kelime params kelimesidir.

    public static double Calculate(params double[] items)
    {
        return Enumerable.Sum(items);
    }

    public static string Calculate(string firstName, string lastName, params double[] prices)
    {
        double sum = Enumerable.Sum(prices);
        string bill = $"""
            Müşteri,
            Sayın, {firstName} {lastName}
            Toplam ödemeniz gereken tutar : {sum} AZN
            """;

        return bill;
    }

    // Müşterinin adını, Soyadını, ve aldığı ürünlerin fiyatını alıp, kullanıcıya ne kadar ödemesi gerektini ekrana yazan metot yazınız, geriye formatlı bir string dönsün

    /*
     
     Müşteri;
     Sayın, Murat Vuranok
     Toplam ödemeniz gerken tutart : 257 AZN

     */ 

    public static void Main(String[] args)
    {
        double[] prices = { 12, 15.45, 12, 58, 74.99, 12, 25, 74, 59 };
        double sum = Calculate(prices);


        double sum1 = Calculate(prices);
        double sum2 = Calculate(new[] { 12, 15.0, 45, 12, 58, 74, 99, 12, 25, 74, 59 });
        double sum2Bucuk = Calculate(new double[] { 12, 15, 45, 12, 58, 74, 99, 12, 25, 74, 59 });
        double sum3 = Calculate(12, 15, 45, 12, 58, 74, 99, 12, 25, 74, 59);


        string result = Calculate("Murat", "Vuranok", 12, 15, 45, 12, 58, 74, 99, 12, 25, 74, 59);

        Console.WriteLine(result);
        return;

        //if (SaveChangeAsync(out int? adet))
        //{
        //    //return RedirectToAction(nameof(Index) , model : adet);
        //}
        //bool sonuc = SaveChangeAsync();
        //if (sonuc)
        //{
        //    //return RedirectToAction(nameof(Index));
        //}


        if (TrySaveChangeAsyc("", out int? sayi))
        {

        }

        var sonuc = SaveChange("");
        if (sonuc.success)
        {
            int v = sonuc.result.Value;
        }


        //int toplamSonuc;
        //Hesapla(10, 25, out toplamSonuc);
        //Console.WriteLine(toplamSonuc);

        //int toplamSonucu; 
        Calculate(10, 30, out int toplamSonucu, out double bolumSonucu, out long carpimSonucu, out int cikartmaSonucu, out int modSonucu);

        Console.WriteLine(
            $"""
            Toplama  Sonucu : {toplamSonucu}
            Bölme    Sonucu : {bolumSonucu}
            Çarpma   Sonucu : {carpimSonucu}
            Çıkartma Sonucu : {cikartmaSonucu}
            Mod      Sonucu : {modSonucu}
            """);



        var result1 = YukaridakiMetot(10, 30);
        // Tuple :)
        //(int Toplam, double Bolum, long Carpim, int Fark, int Mod) result1 = YukaridakiMetot(10, 30);

        Console.WriteLine($"""
            Toplama  Sonucu : {result1.Toplam}
            Bölme    Sonucu : {result1.Bolum}
            Çarpma   Sonucu : {result1.Carpim}
            Çıkartma Sonucu : {result1.Fark}
            Mod      Sonucu : {result1.Mod}
            """);
    }
}