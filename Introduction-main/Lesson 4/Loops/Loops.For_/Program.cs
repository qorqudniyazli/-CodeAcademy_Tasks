#region Description
/*

Döngüler -> tekrarlı yapılması gereken işlerini var ise, döngü kullanarak bunları hızlı bir şekilde yapabilirsiniz :)

Toplamda 4 adet döngü çeşidimiz vardır.

1) for
2) foreach
3) while
4) do-while

*/

// for -> index mekjanizması üzerinden çalışır, bir başlangıç birde bitiş değeri vardır, bu iki değer arasında yapılmasını istediğiniz işlemleri scope içerisinde tanımlamanız yeterlidir. 
#endregion

using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Loops.For_;
public static class Program
{
    public static void Ornek1()
    {
        for (int i = 0; i <= 100; i++)
        {
            //Console.WriteLine("Index No : " + i);
        }
    }
    public static void Ornek2()
    {

        // 1) 1000 ile 1 arasındaki sayıları ekrana yazdırınız. 
        for (int i = 1000; i >= 1; i--)
        {
            // Console.WriteLine(i);
        }
    }
    public static void Ornek3()
    { // 2) 0 ile 1000 arasında yer alan çift sayıları ekrana yazdırınız
        for (int i = 0; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                //  Console.WriteLine(i);
            }
        }

        for (int i = 0; i <= 1000; i += 2)
        {
            // Console.WriteLine(i);
        }
    }
    public static void Ornek4()
    {// 3) A ile Z aralığında yer alan harf'leri ekrana yazdırınız. ( alfabe )
        for (char i = 'A'; i <= 'Z'; i++)
        {
            // Console.WriteLine(i);
        }
    }
    public static void Ornek5()
    {
        // 1 ile 100 arasındaki sayıların toplamı ekrana yazdırınız 
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
    public static void Ornek6()
    {
        //  1945 yılından itibaren günümüz yılına kadar olan yılları  listeleyiniz (1990 - 1992) yılları hariç

        for (int i = 1945; i <= 2023; i++)
        {
            if (i != 1990 && i != 1992)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
                Console.ResetColor();
            }

            switch (i)
            {
                case int x when x != 1990 && x != 1992:
                    {
                        Console.WriteLine(i);
                        break;
                    }
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ResetColor();
                    break;
            }
        }
    }
    public static void Ornek7()
    {
        // dizi içerisinde yer alan takımları, consol'a yazdırınız...
        string[] takimlar = { "beşiktaş", "fenerbahçe", "galatasaray", "trabzonspor", "ankaragücü", "süvas spor", "malatya spor" };

        for (int i = 0; i < takimlar.Length; i++)
        {
            Console.WriteLine(takimlar[i]);

            string takim = takimlar[i];
            Console.WriteLine(takim);
        }
    }
    public static void Ornek8()
    {

        int[] sayisalDizi = { 2, 3, 4, 5, 6, 7, 8, 9, 33, 44, 55, 66, 33, 22, 98, 1, 45, 123, 43, 999, 88, 77, 65, 43 };

        // sayısal bir dizi tanımlayınız, (içeriğine siz karar verin) Array sınıfı kullanmadan enküçük ve enbüyük elemanı Console  içerisinde kulanıcıya gösteriniz..

        int enBuyukSayi = int.MinValue; // 66
        int enKucukSayi = int.MaxValue; // -50


        for (int i = 0; i < sayisalDizi.Length; i++)
        {
            int sayi = sayisalDizi[i];

            if (enBuyukSayi < sayi)
                enBuyukSayi = sayi;

            if (enKucukSayi > sayi)
                enKucukSayi = sayi;
        }

        Console.WriteLine($"""
            Dizi içerisinde yer alan :

            En büyük sayı : {enBuyukSayi}
            En küçük sayı : {enKucukSayi}
            """);
    }
    public static void Ornek9()
    {
        // Yukarıda yer alan, dizi içerisindeki tek ve çift sayıların adedini kullanıcıya gösteriniz.

        int[] sayisalDizi = { 2, 3, 4, 5, 6, 7, 8, 9, 33, 44, 55, 66, 33, 22, 98, 1, 45, 123, 43, 999, 88, 77, 65, 43 };

        int tekSayilar = 0;
        int ciftSayilar = 0;

        for (int i = 0; i < sayisalDizi.Length; i++)
        {
            int sayi = sayisalDizi[i];
            if (sayi % 2 == 0)  // sayi çift ise,
            {
                ciftSayilar++;
            }
            else
            {
                tekSayilar++;
            }
        }

        Console.WriteLine("\n");
        Console.WriteLine($"""
            Dizi içerisinde yer alan :

            Çift Sayıların Toplamı : {ciftSayilar}
            Tek  Sayıların Toplamı : {tekSayilar}
            """);
    }
    public static void Ornek10()
    {
        // Kullanıcının dışarıdan girdiği metinsel değeri, tersten ekrana yazdırınız
        // murat -> tarum

        Console.Write("Lütfen metinsel değer giriniz : ");
        string metin = Console.ReadLine();  // string = char[]
        string newMetin = string.Empty;

        // murat -> murat

        for (int i = metin.Length - 1; i >= 0; i--)
        {
            newMetin += metin[i];
        }

        Console.WriteLine($"{metin} -> {newMetin}");
    }
    public static void Ornek11()
    {
        // Kullanıcıdan aldığınız sayısal değerin toplamını kullanıcıya gösteriniz.
        // 123   => 1+2+3 => 6

        Console.Write("Lütfen sayısal değer giriniz : ");
        string sayisalDeger = Console.ReadLine();
        int toplam = 0;

        for (int i = 0; i < sayisalDeger.Length; i++)
        {
            toplam += int.Parse(sayisalDeger[i].ToString());  // 1 -> 49 2 -> 50 3 -> 51
        }

        Console.WriteLine(toplam);
    }
    public static void Ornek12()
    {
        // yan yana 5 adet X yazdırınız ( döngü kullanın :) )
        // X X X X X

        string text = "";
        for (int i = 0; i < 5; i++)
        {
            text += "X ";
        }

        Console.WriteLine(text);
    }
    public static void Ornek13()
    {
        // alt alta 5 adet X yazdırınız ( döngü kullanın :) )

        string text = "";
        for (int i = 0; i < 5; i++)
        {
            text += "X\n";
        }
        Console.WriteLine(text);
    }
    public static void Ornek14()
    {
        // verilen değere göre Kare çizdiriniz.
        /*
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
        */

        Console.Write("Lütfen bir sayı giriniz : ");
        string sayi = Console.ReadLine();

        #region Old
        //int s = 0;

        //bool result = int.TryParse(sayi, out s);

        //if (result)
        //    for (int i = 0; i < s; i++)
        //    {

        //    } 
        #endregion 

        if (int.TryParse(sayi, out int number))
        {
            string text = "";
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    text += "X ";
                }
                text += "\n";
            }

            Console.WriteLine(text);
        }
    }
    public static void Ornek15()
    {
        // X ile dik kenar üçgen çiziniz
        /*
        X
        X X
        X X X
        X X X X
        X X X X X
        X X X X X X
        X X X X X X X
        X X X X X X X X
        */



        Console.Write("Lütfen sayısal değer giriniz : ");
        string text = "";
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    text += "X ";
                }
                text += "\n";
            }
            Console.WriteLine(text);
        }
    }
    public static void Ornek16()
    {
        #region Colors
        string[] colors =
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
        #endregion


        // 1 X 1 = 1
        // 1 X 10 = 10

        // ---------------

        // 10 X 10 = 100

        Random rnd = new Random();
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                string text = $"{i} X {j} = {i * j}";
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[rnd.Next(colors.Length)]);
                Console.WriteLine(text);
            }

            Console.ResetColor();
            Console.WriteLine(new String('-', 30));
        }
    }
    public static void Ornek17()
    {
        /*
            X X X X X X X X X X X X X
            X                       X
            X                       X
            X                       X
            X                       X
            X                       X
            X                       X
            X                       X
            X X X X X X X X X X X X X */

        // isteyen bu örnekleri console üzerinde yapabilir.
    }

    public static void Main(String[] args)
    {
        Ornek16();
    }
}
