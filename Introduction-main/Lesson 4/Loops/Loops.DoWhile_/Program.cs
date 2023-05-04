namespace Loops.DoWhile_;


public static class Program
{
    public static void Main(String[] args)
    {

        int i = 100;
        while (i < 100)
        {
            Console.WriteLine(i);
        }



        do
        {
            Console.WriteLine(i);
        } while (i < 100);


        // dışarıdan kullancı adı ve şifresi girilecek.
        // username = admin
        // password = 123

        // Kullanıcı bilgileri doğru girene kadar. kullanıcı adı ve şifre devamlı istenecek.


    }
}