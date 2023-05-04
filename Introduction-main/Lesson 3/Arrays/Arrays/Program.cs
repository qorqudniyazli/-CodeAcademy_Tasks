namespace Arrays;

public static class Program
{

    // bir dizi tanımlayınız ve o dizinin son elemanını console üzerinde kullanıcıya gösteriniz.


    // dizi içerisinde yer alan elemanlardan rastgele bir tanesini ekrana yazdırınız

    public static void Main(String[] args)
    {
        #region Array Tanımlama
        // Array  -> en performanslı çalışan liste yapısı

        // Array tanımlama 3 farklı yok izleyebilirsiniz.


        // .net yazılım dilinde index ( başlangıç ) değeri 0'dan
        // sql'de index ( başlangıç ) 1'den başlar

        /*
             Eleman Sayısı  ->   1 2 3 4 5 6 7 8 9
             Index Numarası ->   0 1 2 3 4 5 6 7 8
           
         */






        // 1) Kullanım Şekli

        string[] sehirler = new string[5];
        sehirler[0] = "Ankara";
        sehirler[1] = "İstanbul";
        sehirler[2] = "Edirne";
        sehirler[3] = "Sivas";
        sehirler[4] = "Malatya";
        //sehirler[5] = "Bursa";
        //sehirler[6] = true.ToString();
        //sehirler[7] = 1;

        // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

        string sehir = sehirler[0];
        //Console.WriteLine(sehir);

        //string sayi = 1.ToString();


        // 2) Kullanım Şekli
        int[] sayilar = new int[5] { 1, 2, 3, 4, 5 };


        // 3) Kullanım Şekli
        char[] _karakterler = new[] { 'a', 'b', 'c', 'd', 'e' };
        var karakterler = new[] { 'a', 'b', 'c', 'd', 'e' };

        //int s = 'a';
        //char s1 = 'a';
        //string s2 = 'a'.ToString(); 
        #endregion



        string[] arabalar = { "Audi", "Mercedes", "Ferri", "Tofaş", "BMW", "Bugatti", "Renault" };
        Console.WriteLine(arabalar[arabalar.Length - 1]);



        Random rnd = new Random();
        int randomNumber = rnd.Next(0, arabalar.Length);

        int randomNuberV1 = new Random().Next(arabalar.Length);
        int randomNuberV2 = Random.Shared.Next(arabalar.Length);  // thread safe  

        string randomItem = arabalar[randomNuberV2];
        Console.WriteLine(randomItem);

    }
}



