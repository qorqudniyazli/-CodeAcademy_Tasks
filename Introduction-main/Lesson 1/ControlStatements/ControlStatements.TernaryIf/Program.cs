namespace ControlStatements.TernaryIf;

public static class Program
{
    public static void Main(String[] args)
    {
        #region Yas X
        int yas = 17;
        #endregion

        string? ifResult = "";
        if (yas >= 18)
        {
            ifResult = "Giriş Yapabilir";
        }
        else
        {
            ifResult = "Giriş Yapamaz";
        }

        Console.WriteLine(ifResult);



        string? switchResult = "";

        switch (yas)
        {

            case >= 18:
                {
                    switchResult = "Giriş Yapabilir";
                    break;
                }
            default:
                switchResult = "Giriş Yapamaz";
                break;
        }

        Console.WriteLine(switchResult);


        Console.WriteLine(yas >= 18 ? "Giriş Yapabilir" : "Giriş Yapamaz");

        // db kayıt işlemi, eklendiyse true, eklenmedi ise false
        //bool result = await _context.SaveChangesAsync() > 0;
        bool result = false;

        // ? Parametrede Gönderdiğiniz Kayıt Eklendi
        // : Parametrede Gönderdiğiniz Kayıt Eklenmedi
        Console.WriteLine(result ? "Parametrede Gönderdiğiniz Kayıt Eklendi" : "Parametrede Gönderdiğiniz Kayıt Eklenemedi");



        Console.WriteLine($"Parametrede Gönderdiğiniz Kayıt Eklen{(result ? "" : "me")}di");



        // 0 ile 10  (dahil) -> Kırmızı
        // 11 ile 20 (dahil) -> Mavi
        // 21 ile 30 (dahil) -> Sarı
        // 31 ile 40 (dahil) -> Yeşil

        int x = 123;

        if (x >= 0 && x <= 40)
        {
            if (x <= 10) { }
            else if (x <= 20) { }
            else if (x <= 30) { }
            else { }
        }

        if (x >= 0 && x <= 10) { }
        else if (x >= 11 && x <= 20) { }
        else if (x >= 21 && x <= 30) { }
        else if (x >= 31 && x <= 40) { }
        else { }



        string? retVal =
              (x >= 0 && x <= 10) ? "Kırmızı"
            : (x <= 20) ? "Mavi"
            : (x <= 30) ? "Sarı"
            : (x <= 40) ? "Yeşil" : "Geçersiz Renk";

        Console.WriteLine(retVal);

        retVal = (x >= 0 && x <= 40)
            ? (x <= 10) ? "Kırmızı" : (x <= 20) ? "Mavi" : (x <= 30) ? "Sarı" : (x <= 40) ? "Yeşil" : "Geçersiz Renk" : "Geçersiz Renk Aralığı";


        Console.WriteLine(retVal);
    }
}