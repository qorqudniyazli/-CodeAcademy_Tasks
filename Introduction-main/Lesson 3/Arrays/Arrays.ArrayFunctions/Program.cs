namespace Arrrays.ArrayFunctions;

public static class Program
{
    public static string[] cities = {
            "ankara",
            "edirne",
            "eskişehir",
            "bursa",
            "denizli",
            "kastamonu",
            "eskişehir",
            "artvin",
            "malatya",
            "süvas" // sivas
        };

    public static void Clear() { Array.Clear(cities); }

    public static void ClearV2()
    {
        // 1. Parametre -> Hangi dizi(array)
        // 2. Parametre -> Başlangıç index değeri
        // 3. Parametre -> Silinecek olan eleman sayısı
        Array.Clear(cities, 0, 5);
    }

    public static void Copy()
    {
        // Bir aray içerisinde yer alan eleman(ları) başka bir aray(dizi) içerisine kopyalama işlemi

        string[] sehirler = new string[5];

        // 1. Parametre -> Hangi dizi, verilerin alınacağı dizi
        // 2. Parametre -> Hangi dizi, verilerin kopyalanacağı dizi
        // 3. Parametre -> Kopyalanacak olan eleman sayısı

        Array.Copy(cities, sehirler, 5);
    }

    public static void CopyV2()
    {
        string[] sehirler = new string[5];

        // 1. Parametre -> Hangi dizi, verilerin alınacağı dizi
        // 2. Parametre -> Hangi dizi, verilerin alınacağı dizinin kaçıncı index değeri
        // 3. Parametre -> Hangi dizi, verilerin kopyalanacağı dizi
        // 4. Parametre -> Verilerin kopyalanacağı dizinin, kaçıncı index değerinden itibaren kopyalansın
        // 5. Parametre -> Kopyalanacak olan eleman sayısı
        Array.Copy(cities, 3, sehirler, 2, 3);
    }

    public static void IndexOf()
    {
        // parametrede gönderdiğiniz değerin, array içerisindeki index değerini teslim eder, dizi içerisinde eleman var ise, bulduğu ilk elemanın index değerini, yok ise, -1 değerini teslim eder

        // NOT: dizi içerisinde aynı elemandan birden fazla var ise, ilk bulduğu elemanın index değerini teslim eder.

        string param = "eskişehir";

        int index = Array.IndexOf(cities, param);
        Console.WriteLine($"Parametrede gönderdiğiniz \"{param}\" değeri dizi içerisinde yer alma{(index != -1 ? "" : "ma")}ktadır\nElemanın Index Değeri : {index}");
    }

    public static void LastIndexOf()
    {
        string param = "eskişehir";

        int index = Array.LastIndexOf(cities, param);
        Console.WriteLine($"Parametrede gönderdiğiniz \"{param}\" değeri dizi içerisinde yer alma{(index != -1 ? "" : "ma")}ktadır\nElemanın Index Değeri : {index}");
    }

    public static void Resize()
    {
        // var olan bir array'i yeniden boyutlandırmak için kullanırız.


        Array.Resize(ref cities, 50);
    }

    public static void Sort()
    {

        // array içerisinde yer alan elemanları A-Z'ye  0'dan 9'a sıralama yapar

        Array.Sort(cities);
    }

    public static void Reverse()
    {
        // array içerisinde yer alan elemanların üzerinde işlem yapmadan, array elemanlarını tersine çevirir.

        // murat -> tarum yapmaz :)
        Array.Reverse(cities);
    }

    public static void Exists()
    {
        // bir array içerisinde parametrede gönderdiğiniz elemanın var olup olmadığını expression ile kontrol edebilirsiniz.

        Console.Write("Lütfen Şehir Adı Giriniz : ");
        string sehir = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(sehir))
        {
            bool result = Array.Exists(cities, c => c == sehir);
            Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Parametrede gönderdiğiniz eleman, dizi içerisinde yer alma{(result ? "" : "ma")}ktadır");
            Console.ResetColor();
        }
    }

    public static void Contains()
    {
        // parametrede gönderdiğiniz elemanın dizi içerisinde yer alıp almadığını bool olarak teslim eder.
        // eleman dizi içerisinde var ise, true yok ise, false değerini teslim eder.

        Console.Write("Lütfen Şehir Adı Giriniz : ");
        string sehir = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(sehir))
        {
            bool result = cities.Contains(sehir); // Array metot olmadığı için :) kullanmıyoruz şuan :)
            Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Parametrede gönderdiğiniz eleman, dizi içerisinde yer alma{(result ? "" : "ma")}ktadır");
            Console.ResetColor();
        }
    }

    public static void ExampleV1()
    {

        string param = "eskişehir";

        if (Array.IndexOf(cities, param) != Array.LastIndexOf(cities, param))
        {
            // dizi içerisinde birden fazla kez geçmektedir
        }
        else
        {
            // dizi içerisinde bir defa geçmektedir
        }


    }

    public static void Main(String[] args)
    {
        //Clear();
        //ClearV2();
        //Copy();
        //CopyV2();
        //IndexOf();
        //LastIndexOf();
        //Resize();
        //Sort(); 
        //Reverse();  
        //Exists();
        Contains();
    }
}