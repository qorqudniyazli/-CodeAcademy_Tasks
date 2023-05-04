namespace Functions.Void_;

public static class Program
{
    // Metot tanımlama sırasında  uyulması gereken kurallar
    /*
        1) Metot isimleri, tanımlı kelimeler olamaz ( Random, Program vb. )
        2) Sayı ile başlayamaz, ama sayı içerebilir veya bitebilir
        3) Özel karakter kullanamazsınız ( _ ) hariç
        4) Birden fazla kelimeden oluşamaz, eğer birden fazla kelime içeriyorsa, _ ile ayırmanız veya, Birleşik olarak yazmanız gerekir.
        5) Yazılım kuralı gereği, zorunlu değil :) Büyük harf ile başlar
        6) Metot içerisinde, değerin nereden geleceği belirtilmez.
        7) Metot içerisinde, parametreden gelen değere değer atanmaz :)
     */


    public static void Hesapla()
    {
        Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
        int s1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
        int s2 = int.Parse(Console.ReadLine());

        int toplam = s1 + s2;
        Console.WriteLine(toplam);
    }
    public static void Calculate(int s1, int s2)
    {
        int toplam = s1 + s2;
        Console.WriteLine(toplam);
    }
    public static void SayisalLoto(int kolon)
    {
        Random rnd = new Random();
        for (int i = 0; i < kolon; i++)
        {
            string[] numbers = new string[6];
            int index = 0;
            while (index < numbers.Length)
            {
                string sayi = rnd.Next(1, 50).ToString("D2");
                if (!numbers.Contains(sayi))
                {
                    numbers[index] = sayi;
                    index++;
                }
            }

            Array.Sort(numbers);
            Console.WriteLine(string.Join(" - ", numbers));
        }
    }
    public static void SonUcHarfBukucu(string text)
    {
        // dışarıdan girilen değer, 3 harfe eşit veya küçükse tamamını, uzunluğu 3 harften büyükse, son 3 harfi kullanıcıya console içerisinde gösteriniz. 

        //Console.WriteLine(text.Length <= 3 ? text : text.Substring(text.Length - 3));
        if (text.Length <= 3)
        {
            // tüm text gösterilir
        }
        else
        {
            // son üç hane gösterilir.
        }

        string result = text.Length switch
        {
            > 3 => text.Substring(text.Length - 3),
            _ => text
        };

        Console.WriteLine(result);
    }
    public static void EMail(string mails)
    {
        // Kullanıcı dışarından mail adresleri girecek, örn -> murat.vuranok@code.edu.az;;;;;isim@soyisim.com;;;;;;;murat@vuranok.com;;;;;;adim@soyadim.com

        var mailAdresleri = mails.Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (string mail in mailAdresleri)
        {
            Console.WriteLine(mail);
        }
    }
    public static void SaitKontrolV1(string param)
    {
        Console.Clear();

        char[] karakterler = param
            .ToLower()
            .ToCharArray();

        int saitCount = 0,
            samitCount = 0;

        for (int i = 0; i < karakterler.Length; i++)
        {
            switch (karakterler[i])
            {

                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':
                    {
                        saitCount++;
                        break;
                    }
                default:
                    samitCount++;
                    break;
            }
        }

        Console.WriteLine($"""
            Girilen metin içerisinde;
            Toplam Sait sayısı  : {saitCount}
            Toplam Samit sayısı : {samitCount}
            """);
    }
    public static void SaitKontrolV2(string param)
    {
        Console.Clear();

        char[] karakterler = param
            .ToLower()
            .ToCharArray();

        char[] sait_karakterler =
        {
            'a','e','ı','i','o','ö','u','ü'
        };

        int saitCount = 0,
            samitCount = 0;

        for (int i = 0; i < karakterler.Length; i++)
        {
            bool result = false;
            for (int j = 0; j < sait_karakterler.Length; j++)
            {
                if (karakterler[i] == sait_karakterler[j])
                {
                    saitCount++;
                    result = true;
                    break;
                }
            }
            if (!result)
                samitCount++;
        }

        Console.WriteLine($"""
            Girilen metin içerisinde;
            Toplam Sait sayısı  : {saitCount}
            Toplam Samit sayısı : {samitCount}
            """);
    }
    public static void SaitKontrolV3(string param)
    {
        Console.Clear();

        char[] karakterler = param
            .ToLower()
            .ToCharArray();

        char[] sait_karakterler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        int saitCount = 0,
            samitCount = 0;

        foreach (var karakter in karakterler)
        {
            if (sait_karakterler.Contains(karakter))
            {
                saitCount++;
            }
            else
            {
                samitCount++;
            }
        }

        Console.WriteLine($"""
            Girilen metin içerisinde;
            Toplam Sait sayısı  : {saitCount}
            Toplam Samit sayısı : {samitCount}
            """);
    }


    /* 
       Metot Overload
    */

    /// <summary>
    /// Mail Ekleme Metodu
    /// </summary>
    public static void Mail() { }

    /// <summary>
    /// Mail Ekleme Metodu
    /// </summary>
    /// <param name="firstname">Personelin Adını Giriniz</param>
    public static void Mail(string firstname) { }

    /// <summary>
    /// Mail Ekleme Metodu
    /// </summary>
    /// <param name="firstname">Personelin Adını Giriniz</param>
    /// <param name="lastname">Personelin Soyadını Giriniz</param>
    public static void Mail(string firstname, string lastname) { }

    /// <summary>
    /// Mail Ekleme Metodu
    /// </summary>
    /// <param name="firstname">Personelin Adını Giriniz</param>
    /// <param name="lastname">Personelin Soyadını Giriniz</param>
    /// <param name="domain">Kullanıcı mail adresi için domain adı giriniz</param>
    public static void Mail(string firstname, string lastname, string domain) { }

    /// <summary>
    /// Mail Ekleme Metodu
    /// </summary>
    /// <param name="firstname">Personelin Adını Giriniz</param>
    /// <param name="lastname">Personelin Soyadını Giriniz</param>
    /// <param name="domain">Kullanıcı mail adresi için domain adı giriniz</param>
    /// <param name="extention">Mail adresi domain uzantısını giriniz</param>
    public static void Mail(string firstname, string lastname, string domain, string extention) { }


     
    public static void Mail(int s, string t) { }
    public static void Mail(string s, int t) { }



    public static void Main(String[] args)
    {
        #region Örnekler
        //Hesapla();

        //Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
        //int sayi = int.Parse(Console.ReadLine());

        //Calculate(sayi, 58);

        //SayisalLoto(10);
        //SonUcHarfBukucu("Code");
        //SonUcHarfBukucu("Cod");
        //SonUcHarfBukucu("Co");
        //SonUcHarfBukucu("C");

        //Console.Write("Lütfen mail adreslerini giriniz : ");
        //EMail(Console.ReadLine());


        //Console.Write("Lütfen metin giriniz : ");
        //string metin = Console.ReadLine();
        //SaitKontrolV1(metin);
        //SaitKontrolV2(metin);
        //SaitKontrolV3(metin); 
        #endregion

        Mail("Murat", "Vuranok");
        Mail("Murat");

        Convert.ToInt32("");
    }


}

