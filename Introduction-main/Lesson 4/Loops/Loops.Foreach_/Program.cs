using Spectre.Console;

namespace Loops.Foreach_;


public static class Program
{
    public static string[] sehirler = {
                "Adana",
                "Adıyaman",
                "Afyonkarahis",
                "Ağrı",
                "Aksaray",
                "Amasya",
                "Ankara",
                "Antalya",
                "Ardahan",
                "Artvin",
                "Aydın",
                "Balıkesir",
                "Bartın",
                "Batman",
                "Bayburt",
                "Bilecik",
                "Bingöl",
                "Bitlis",
                "Bolu",
                "Burdur",
                "Bursa",
                "Çanakkale",
                "Çankırı",
                "Çorum",
                "Denizli",
                "Diyarbakır",
                "Düzce",
                "Edirne",
                "Elazığ",
                "Erzincan",
                "Erzurum",
                "Eskişehir",
                "Gaziantep",
                "Giresun",
                "Gümüşhane",
                "Hakkâri",
                "Hatay",
                "Iğdır",
                "Isparta",
                "İstanbul",
                "İzmir",
                "Kahramanmara",
                "Karabük",
                "Karaman",
                "Kars",
                "Kastamonu",
                "Kayseri",
                "Kırıkkale",
                "Kırklareli",
                "Kırşehir",
                "Kilis",
                "Kocaeli",
                "Konya",
                "Kütahya",
                "Malatya",
                "Manisa",
                "Mardin",
                "Mersin",
                "Muğla",
                "Muş",
                "Nevşehir",
                "Niğde",
                "Ordu",
                "Osmaniye",
                "Rize",
                "Sakarya",
                "Samsun",
                "Siirt",
                "Sinop",
                "Sivas",
                "Şanlıurfa",
                "Şırnak",
                "Tekirdağ",
                "Tokat",
                "Trabzon",
                "Tunceli",
                "Uşak",
                "Van",
                "Yalova",
                "Yozgat",
                "Zonguldak" };
    public static string[] colors =
        {
            "DarkBlue",
            "DarkGreen",
            "DarkCyan",
            "DarkRed",
            "DarkMagenta",
            "DarkYellow",
            "Gray",
            "DarkGray",
            "Blue",
            "Green",
            "Cyan",
            "Red",
            "Magenta",
            "Yellow",
            "White",
            "Black",
            "DarkBlue",
            "DarkGreen",
            "DarkCyan",
            "DarkRed",
            "DarkMagenta",
            "DarkYellow",
            "Gray",
            "DarkGray",
            "Blue",
            "Green",
            "Cyan",
            "Red",
            "Magenta",
            "Yellow",
            "White" };




    // foreach -> collection bağımlı döngü çeşididir.


    public static void Ornek1()
    {
        //for (int i = 0; i < sehirler.Length; i++)
        //{
        //    string sehir = sehirler[i];
        //    Console.WriteLine(sehir);
        //}
        Random rnd = new Random();
        foreach (string sehir in sehirler)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[rnd.Next(colors.Length)]);
            Console.WriteLine(sehir);
        }
    }


    public static void Ornek2()
    {
        // 1) içeriğine sizin karar verdiğiniz sayısal bir dizi tanımlayınız,
        // 2) ve o dizi içerisinde yer alan tek sayıları ve çift sayıları ayrı bir dizi içerisine
        // 3) atınız,
        // 4) işlem sonunda o diziler içerisinde kaç eleman var kullanıcya gösteriniz:

        int[] sayisal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 12, 23, 34, 45, 56, 67, 78, 89, 90 };
        int[] tekSayilar = new int[0];
        int[] ciftSayilar = new int[0];

        foreach (int sayi in sayisal)
        {
            if (sayi % 2 == 0)
            {
                Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
                ciftSayilar[ciftSayilar.Length - 1] = sayi; 
            }
            else
            {
                Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
                tekSayilar[tekSayilar.Length - 1] = sayi;
            }
        }

        Console.WriteLine(
            $"""
            Toplamda Eleman Sayısı : {sayisal.Length}
            Çift Sayıların Toplamı : {ciftSayilar.Length}
            Tek Sayıların Toplamı  : {tekSayilar.Length}
            """
            );
    }
    public static void Main(String[] args)
    {
        //Ornek1();

        //var table = new Table().Centered();

        //AnsiConsole.Live(table)
        //        .AutoClear(false)   // Do not remove when done
        //        .Overflow(VerticalOverflow.Ellipsis) // Show ellipsis when overflowing
        //        .Cropping(VerticalOverflowCropping.Top) // Crop overflow at top
        //        .Start(ctx =>
        //        {
        //            foreach (var item in sehirler.Take(10))
        //            {
        //                table.AddColumn(item); ctx.Refresh(); Thread.Sleep(100);
        //            }
        //        });


        Ornek2();
    }
}