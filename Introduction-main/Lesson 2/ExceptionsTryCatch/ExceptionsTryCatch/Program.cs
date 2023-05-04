namespace ExceptionsTryCatch;

public static class Program
{
    public static void Main(String[] args)
    {

        // Hatalı Kodlama Örneği ( hata yönetimi olmadığı için )

        //Console.Write("Lütfen Telefon Numaranızı Giriniz : ");
        //int telefonNumarasi = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Tebrikler, Telefon numarasını girmeyi başardırdınız : {0}", telefonNumarasi);

        try
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sadece Sayısal Veri Giriniz!\n");
            Console.Write("Boş Değer Girmeyin!\n");
            Console.Write("Çok Fazla Sayı Girmeyin!\n");
            Console.ResetColor();

            Console.Write("Lütfen Telefon Numaranızı Giriniz : ");
            int telefonNumarasi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tebrikler, Telefon numarasını girmeyi başardırdınız : {0}", telefonNumarasi);
        }
        catch (NullReferenceException ex) { }
        catch (ArgumentOutOfRangeException ex) { }
        catch (FormatException ex) { } // Metin Formatlama ile ilgilenen arkadaşa mail gönder,  -> catch (DivideByZeroException ex) { }
        catch (Exception ex)
        {

            // Yukarıda yer alan, kod blokları içerisinde bir hata meydana gelirse, bu alan çalışacak,

            // Kullanıcı Mesajı
            Console.WriteLine("Hata Meydana Geldi!");
            Console.WriteLine("Hata Log : {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Her işlem sonunda mecburen çalışır, fazla kaynağınız varsa, mutlaka ekleyin. Havalı görünüyor :)");
        }
    }
}