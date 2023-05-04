
/*
 
 Karşılaştırma operatörleri
 
    1) == ->  soldaki değerin, sağdaki değere eşit olma durumu               -> true
    2) != ->  soldaki değerin, sağdaki değere eşit olmama durumu             -> true
    3) >      soldaki değerin, sağdaki değer'den büyük olma durumu           -> true
    4) <      soldaki değerin, sağdaki değer'den küçük olma durumu           -> true
    5) >=     soldaki değerin, sağdaki değere büyük veya eşit olma durumu    -> true
    6) <=     soldaki değerin, sağdaki değer'den küçük veya eşit olma durumu -> true
    7) !      olumsuzluk 
 */

string userName = "admin";
string password = "123!";


//bool result = (userName == "admin"); // db içerisinden gelen sonuç


//if (!result) { return; }
//if (result != true) { return; }

if (userName == "admin")
{
    if (password == "123")
    {
        Console.WriteLine("Kullanıcı Girişi Yaptınız!");
    }
    else
    {
        Console.WriteLine("Kullanıcı Bilgilerinizi Kontrol Ediniz!");
    }
}
else
{
    Console.WriteLine("Kullanıcı Bilgilerinizi Kontrol Ediniz!");
}


bool varMi = false;
int cekmeceCount = 1;


// 1. Çekmece 
if (varMi)
{
    // Ürünü al, işlemi sonlandır 
}


// 2. Çekmece
if (varMi)
{
    // Ürünü al, işlemi sonlandır 
}

// 50. Çekmece

if (varMi)
{
    // Ürünü al, işlemi sonlandır 
}
else
{
    // Markete Git,
}



/*
  Kullanıcı dışarıdan, not değerini girecek, (0 ile 100 dahil), girilen not değerine göre kullanıcıya harf not teslim edilecek.

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
int not = int.Parse(Console.ReadLine());
string result = "Harf Notunuz {0}";

#region Eski
/*
if (not >= 0 && not <= 35) {       result = string.Format(result, "FF"); }
else if (not > 35 && not <= 45) {  result = string.Format(result, "DD"); }
else if (not > 45 && not <= 50) {  result = string.Format(result, "DC"); }
else if (not > 50 && not <= 55) {  result = string.Format(result, "CC"); }
else if (not > 55 && not <= 63) {  result = string.Format(result, "CB"); }
else if (not > 63 && not <= 71) {  result = string.Format(result, "BB"); }
else if (not > 71 && not <= 80) {  result = string.Format(result, "BA"); }
else if (not > 80 && not <= 100) { result = string.Format(result, "AA"); }
else { result = "Geçersiz Not"; }
*/

#endregion

#region Yeni
/*
Mantıksal Operatörler
&& -> sorguda yer alan tüm koşulların sağlanması durumu -> true, eğer koşullardan 1 tanesi bile false olursa false değeri teslim eder. ( false olduğu anda, diğer koşulları kontrol etmez )
|| -> sorguda yer alan koşullardan 1 tanesi bile true olursa işlem devam eder.

----

&  sorgu içerisinde false olan koşul olsa'da diğer koşulları kontrol eder.
|
*/

if (not >= 0)
{
    if (not <= 100)
    {
        if (not <= 35) { result = string.Format(result, "FF"); }
        else if (not <= 45) { result = string.Format(result, "DD"); }
        else if (not <= 50) { result = string.Format(result, "DC"); }
        else if (not <= 55) { result = string.Format(result, "CC"); }
        else if (not <= 63) { result = string.Format(result, "CB"); }
        else if (not <= 71) { result = string.Format(result, "BB"); }
        else if (not <= 80) { result = string.Format(result, "BA"); }
        else if (not <= 100) { result = string.Format(result, "AA"); }
    }
}
else { result = "Geçersiz Not"; }

//if (not >= 0 && not <= 100)
//{


//}
//else
//{

//} 
#endregion


Console.WriteLine(result);



string isim = "murat";
string soyisim = "vuranok";


/* 
    Adı           :  murat
    Soyadı        :  vuranok
    Mail          : murat.vuranok@code.edu.az
    Kullanıcı Adı :  murat.vuranok
 */

string retVal1 = "Adı : " + isim + "Soyadı : " + soyisim + "Mail : " + isim + "." + soyisim + "@code.edu.az" + "Kullanıcı Adı : " + isim + "." + soyisim;
// Adi : muratSoyadi : vuranokMail : murat.vuranok@code.edu.azKullanici Adi : murat.vuranok



string retVal2 = "Adı     : " + isim + "\nSoyadı   : " + soyisim + "\nMail : " + isim + "." + soyisim + "@code.edu.az" + "\nKullanıcı Adı : " + isim + "." + soyisim;


string retVal3 = string.Format("Adı : {0}\nSoyadı : {1}\nMail : {0}.{1}@code.edu.az\nKullanıcı Adı : {0}.{1}", isim, soyisim);



string retVal4 = $"Adı : {isim}\nSoyadı : {soyisim}\nMail : {isim}.{soyisim}@code.edu.az\nKullanıcı Adı : {isim}.{soyisim}";



string retVal5 = $@"
Adı           : {isim}
Soyadı        : {soyisim}
Mail          : {isim}.{soyisim}@code.edu.az
Kullanıcı Adı : {isim}.{soyisim}";


string q = """


    """;

string retVal6 = $"Adı {(new String(' ', 17))}: {isim}\nSoyadı {(new String(' ', 14))}: {soyisim}\nMail {(new String(' ', 16))}: {isim}.{soyisim}@code.edu.az\nKullanıcı Adı {(new String(' ', 7))}: {isim}.{soyisim}";


string retVal7 = $"Adı {":".PadLeft(17)} {isim}\nSoyadı {":".PadLeft(14)} {soyisim}\nMail {":".PadLeft(16)} {isim}.{soyisim}@code.edu.az\nKullanıcı Adı {":".PadLeft(7)} {isim}.{soyisim}";



string retVal = $"Adı {":",17} {isim}\nSoyadı {":",14} {soyisim}\nMail {":",16} {isim}.{soyisim}@code.edu.az\nKullanıcı Adı {":",7} {isim}.{soyisim}";

Console.WriteLine(retVal);




Console.Write("Lütfen ürün adı giriniz : ");
string urunAdi = Console.ReadLine()
    .ToLower()
    .Trim();


if (string.IsNullOrWhiteSpace(urunAdi))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Lütfen ürün adı giriniz!");
    Console.ResetColor();
    return;
}

#region Description
//urunAdi = urunAdi.Trim();

//if (urunAdi == "" || urunAdi == null || urunAdi == " " || urunAdi == "  " || urunAdi == "   " || urunAdi == "    ")
//{
//    Console.WriteLine("Lütfen ürün adı giriniz : ");
//}
/*
 
 
    // Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
    // Domates, Biber, Patlican                 => Sebze Reyonu
    // Diş Macunu, Parfüm, Şampuan              => Kozmetik Reyonu
    // Cep Telefonu, Bilgisayar, Ses Sistemi    => Teknoloji Reyonu
    // Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
    // Kullanıcı alanı boş geçerse, lütfen bir ürün adı giriniz uyarısı verdiriniz.
  
 */
#endregion

string message = "";
if (urunAdi == "domates" || urunAdi == "biber" || urunAdi == "patlican")
{
    message = "Manav";
}
else if (urunAdi == "dis macunu" || urunAdi == "parfüm" || urunAdi == "sampuan")
{
    message = "Kozmetik";
}
else if (urunAdi == "cep telefonu" || urunAdi == "bilgisayar" || urunAdi == "ses sistemi")
{
    message = "Teknoloji";
}
else
{
    Console.WriteLine("Belirtilen ürün, marketimizde yer almamaktadır.");
    return;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Aradığınız {0} ürünü, {1} reyonundadır.", urunAdi, message);
Console.ResetColor();

/*
 
    // Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...

 */