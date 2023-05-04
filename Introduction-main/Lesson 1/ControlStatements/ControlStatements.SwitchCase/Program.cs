namespace ControlStatements.SwitchCase;

public static class Program
{
    #region Ornek1
    public static void Ornek1()
    {
        // var olan 2 değerin karşılaştırılması

        string userName = "admin";
        if (userName == "admin1")
        {
            Console.WriteLine("Giriş Yaptınız");
        }
        else
        {
            Console.WriteLine("Kullanıcı Bilgilerinizi Kontrol Ediniz");
        }
    }
    #endregion

    #region Ornek2
    public static void Ornek2()
    {
        string userName = "admin1";
        switch (userName)
        {
            case "admin":
                {
                    Console.WriteLine("Giriş Yaptınız");
                    break;
                }
            default:
                {
                    Console.WriteLine("Kullanıcı Bilgilerinizi Kontrol Ediniz");
                    break;
                }
        }
    }
    #endregion

    #region Ornek3
    public static void Ornek3()
    {
        // Kullanıcı dışarıdan mevsim adı girecek, ve kullanıcıya o mevsim içerisinde yer alan ay isimleri teslim edilecek.

        // kis       -> Aralık  - Ocak   - Şubat
        // ilkbahar  -> Mart    - Nisan  - Mayıs
        // yaz       -> Haziran - Temmuz - Ağustos
        // sonbahar  -> Eylül   - Ekim   - Kasım


        Console.Write("Lütfen Mevsim Adı Giriniz : ");
        string mevsim = Console.ReadLine()
            .Trim()
            .ToLower();

        if (!string.IsNullOrWhiteSpace(mevsim))
        {
            string result = string.Empty;
            if (mevsim == "kis") { result = "Aralık  - Ocak   - Şubat"; }
            else if (mevsim == "ilkbahar") { result = "Mart    - Nisan  - Mayıs"; }
            else if (mevsim == "yaz") { result = "Haziran - Temmuz - Ağustos"; }
            else if (mevsim == "sonbahar") { result = "Eylül   - Ekim   - Kasım"; }
            else
            {
                Console.WriteLine("Geçersiz Parametre");
                return;
            }
            Console.WriteLine("Parametrede Gönderdiğiniz Değere Ait Olan AY İsimleri {0}'d(ı)ir : ", result);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lütfen bir değer giriniz!");
            Console.ResetColor();
        }
    }
    #endregion

    #region Ornek3V2
    public static void Ornek3V2()
    {
        Console.Write("Lütfen Mevsim Adı Giriniz : ");
        string? mevsim = Console.ReadLine()
            .Trim()
            .ToLower();

        switch (!string.IsNullOrWhiteSpace(mevsim))
        {
            case true:
                {
                    switch (mevsim)
                    {
                        case "kis":
                            {
                                Console.WriteLine("Aralık  - Ocak   - Şubat");
                                break;
                            }
                        case "ilkbahar":
                            {
                                Console.WriteLine("Mart    - Nisan  - Mayıs");
                                break;
                            }
                        case "yaz":
                            {
                                Console.WriteLine("Haziran - Temmuz - Ağustos");
                                break;
                            }
                        case "sonbahar":
                            {
                                Console.WriteLine("Eylül   - Ekim   - Kasım");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Geçersiz Parametre");
                                break;
                            }
                    }

                    break;
                }

            default:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen bir değer giriniz!");
                    Console.ResetColor();
                    break;
                }
        }
    }
    #endregion

    #region Ornek4
    public static void Ornek4()
    {
        // Kullanıcı dışarıdan ay ismi girdiğinde, hangi(hansı) mevsimde olduğunu ekrana yazdırınız.

        // ocak    -> kis
        // subat   -> kis
        // agustos -> yaz


        Console.Write("Lütfen Ay Adı Giriniz : ");
        string ayAdi = Console.ReadLine()
            .Trim()
            .ToLower();


        if (!string.IsNullOrWhiteSpace(ayAdi))
        {
            if (ayAdi == "aralik" || ayAdi == "ocak" || ayAdi == "subat") { Console.WriteLine("Kış Mevsimi"); }
            else if (ayAdi == "mart" || ayAdi == "nisan" || ayAdi == "mayis") { Console.WriteLine("İlkbahar Mevsimi"); }
            else if (ayAdi == "haziran" || ayAdi == "temmuz" || ayAdi == "agustos") { Console.WriteLine("Yaz Mevsimi"); }
            else if (ayAdi == "eylul" || ayAdi == "ekim" || ayAdi == "kasim") { Console.WriteLine("Sonbahar Mevsimi"); }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz Parametre!");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lütfen bir değer giriniz!");
            Console.ResetColor();
        }
    }
    #endregion

    #region Ornek4V2
    public static void Ornek4V2()
    {
        Console.Write("Lütfen Ay Adı Giriniz : ");
        string ayAdi = Console.ReadLine()
            .Trim()
            .ToLower();


        switch (!string.IsNullOrWhiteSpace(ayAdi))
        {
            case true:
                {

                    switch (ayAdi)
                    {
                        case "aralik":
                        case "ocak":
                        case "subat": { Console.WriteLine("Kış Mevsimi"); break; }

                        case "mart":
                        case "nisan":
                        case "mayis": { Console.WriteLine("İlkbahar Mevsimi"); break; }

                        case "haziran":
                        case "temmuz":
                        case "agustos": { Console.WriteLine("Yaz Mevsimi"); break; }

                        case "eylul":
                        case "ekim":
                        case "kasim": { Console.WriteLine("Sonbahar Mevsimi"); break; }

                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geçersiz Parametre!");
                                Console.ResetColor();
                                break;
                            }
                    }


                    break;
                }
            default:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen bir değer giriniz!");
                    Console.ResetColor();
                    break;
                }
        }
    }
    #endregion

    #region Ornek5
    public static void Ornek5()
    {
        /*
           Kullanıcı dışarıdan, not değerini girecek, (0 ile 100 dahil), 
        girilen not değerine göre kullanıcıya harf not teslim edilecek.

            FF  -> 0     - 35    
            DD  -> 35 >  - 45    
            DC  -> 45 >  - 50    
            CC  -> 50 >  - 55    
            CB  -> 55 >  - 63    
            BB  -> 63 >  - 71    
            BA  -> 71 >  - 80    
            AA  -> 80 >  - 100   
         */


        Console.Write("Lütfen Not Değerinizi Giriniz : ");
        string not = Console.ReadLine();

        switch (!string.IsNullOrWhiteSpace(not))
        {
            case true:
                {

                    int _not = int.Parse(not);
                    switch (_not)
                    {
                        case int n when n >= 0 && n <= 100:
                            {
                                switch (n)
                                {
                                    case int s when s <= 35: { Console.WriteLine("FF"); break; }
                                    case int s when s <= 45: { Console.WriteLine("DD"); break; }
                                    case int s when s <= 50: { Console.WriteLine("DC"); break; }
                                    case int s when s <= 55: { Console.WriteLine("CC"); break; }
                                    case int s when s <= 63: { Console.WriteLine("CB"); break; }
                                    case int s when s <= 71: { Console.WriteLine("BB"); break; }
                                    case int s when s <= 80: { Console.WriteLine("BA"); break; }
                                    case int s when s <= 100: { Console.WriteLine("AA"); break; }
                                }
                                break;
                            }

                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geçersiz Not Girişi!");
                                Console.ResetColor();
                                break;
                            }
                    }
                    break;
                }
            default:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen bir değer giriniz!");
                    Console.ResetColor();
                    break;
                }
        }
    }
    #endregion

    #region Ornek5V2
    public static void Ornek5V2()
    {


        int _yas = 18;
        int _n = 50;



        if (_yas == 18 && _n >= 50)
        {
        }

        switch ((_yas, _n))
        {

            case (0, 0) when _yas > 18 && _n >= 50:
                {
                    break;
                }

            default:
                break;
        }


        Console.Write("Lütfen Not Değerinizi Giriniz : ");
        string? not = Console.ReadLine();

        switch (!string.IsNullOrWhiteSpace(not))
        {
            case true:
                {
                    int _not = int.Parse(not);


                    switch (_not)
                    {
                        // case int n when n >= 0 && n <= 100:
                        case >= 0 and <= 100:
                            {
                                switch (_not)
                                {
                                    //case int s when s <= 35: { Console.WriteLine("FF"); break; }
                                    case <= 35: { Console.WriteLine("FF"); break; }
                                    case <= 45: { Console.WriteLine("DD"); break; }
                                    case <= 50: { Console.WriteLine("DC"); break; }
                                    case <= 55: { Console.WriteLine("CC"); break; }
                                    case <= 63: { Console.WriteLine("CB"); break; }
                                    case <= 71: { Console.WriteLine("BB"); break; }
                                    case <= 80: { Console.WriteLine("BA"); break; }
                                    case <= 100: { Console.WriteLine("AA"); break; }
                                }
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geçersiz Not Girişi!");
                                Console.ResetColor();
                                break;
                            }
                    }


                    break;
                }
        }
    }
    #endregion

    #region Ornek6
    public static void Ornek6()
    {

        // Kullanıcının verdiği renk değerine göre ingilice karşılığını teslim ediniz.

        // Red -> Kırmızı
        // White  -> Beyaz


        Console.Write("Lütfen Renk Giriniz : ");
        string? color = Console.ReadLine();

        string renk = string.Empty;
        switch (color)
        {
            case "Red":
                {
                    renk = "Kırmızı";
                    break;
                }
            case "Blue":
                {
                    renk = "Mavi";
                    break;
                }
            case "Yellow":
                {
                    renk = "Sarı";
                    break;
                }
            default:
                break;
        }

        Console.WriteLine(renk);
    }
    #endregion

    #region Ornek6V2
    public static void Ornek6V2()
    {
        Console.Write("Lütfen Renk Giriniz : ");
        //string? color = Console.ReadLine();
        //string renk = string.Empty;


        string? color = Console.ReadLine() switch
        {
            "Red" => "Kırmızı",   // case
            "White" => "Beyaz",
            "Blue" => "Mavi",
            "Yellow" => "Sarı",
            _ => "Geçersiz Renk Kodu"  // default
        };

        Console.WriteLine(color);
    }
    #endregion

    public static void Main(String[] args)
    {
        //Ornek1();
        //Ornek2();
        //Ornek3();
        //Ornek3V2();
        //Ornek4();
        //Ornek4V2();
        //Ornek5();
        //Ornek5V2();

        Ornek6V2();
    }
}