using System.Text;

namespace SystemIOExample;
public static class Program
{
    #region WriteAllLines
    /// <summary>
    /// Veri yazdırma işlemi
    /// </summary>
    /// <param name="path">dosya yolu veriniz</param>
    public static void WriteAllLines(string path)
    {
        string[] user =
        {
            "murat vuranok",
            "murat.vuranok@code.edu.az",
            "+905323520997",
            "Beşiktaş / İstanbul",
            "Türkiye"
        };


        File.WriteAllLines(path, user);
    }
    #endregion

    #region ReadAllLines
    /// <summary>
    /// Veri okuma işlemi
    /// </summary>
    /// <param name="path">dosya yolu veriniz</param>
    public static void ReadAllLines(string path)
    {
        foreach (var line in File
            .ReadAllLines(path)
            .Select((value, i) => new { value, i }))
        {
            Console.WriteLine($"{line.i + 1} -> {line.value}");
        }
    }
    #endregion

    #region FileInfo
    /// <summary>
    /// Dosya bilgilerini teslim eder.
    /// </summary>
    /// <param name="path">Klasör (qovluq) yolunu veriniz</param>
    public static void FileInfo(string path)
    {

        // ilgili path içerisindeki klasörü (qovluq) teslim eder
        DirectoryInfo info = new DirectoryInfo(path);
        FileInfo[] files = info.GetFiles(searchPattern: "*.txt", searchOption: SearchOption.AllDirectories);

        foreach (FileInfo file in files)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"""

                FileName      -> {file.Name}
                FileLength    -> {file.Length}
                FileDirectory -> {file.DirectoryName}

                """);
            Console.ResetColor();
            Console.WriteLine(new string('-', 150));
        }
    }
    #endregion

    public static void FileStream(string path)
    {
        FileStream fs = File.Open(path, FileMode.Create);

        #region Lorem Text
        string text = """
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor vitae ipsum in gravida. Sed porta, sapien nec posuere consectetur, lorem tellus pretium massa, nec rhoncus lacus risus vitae tortor. Quisque tincidunt arcu et lectus maximus, et hendrerit lacus semper. Phasellus quis ipsum justo. Phasellus porta viverra nulla, quis dapibus nisl scelerisque vitae. Nam id vestibulum nulla. Sed porttitor fringilla magna mattis sollicitudin. Suspendisse viverra magna vitae mi porttitor tempus. Ut sit amet erat ex. Fusce sed dictum ex, ac sagittis tellus. Ut urna dolor, convallis at eleifend ac, mollis lacinia tortor. Aliquam tincidunt, magna ut blandit laoreet, libero odio porttitor dolor, a facilisis erat tortor eget velit. Etiam a lorem eget dolor laoreet ultrices pellentesque ac dolor. Donec eget augue sit amet nisi vulputate rutrum at sit amet purus. Aenean congue rutrum magna id elementum.

            Nulla sit amet sem ultrices, malesuada ante at, malesuada sapien. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Phasellus tempus nec nunc eget vulputate. Sed scelerisque blandit elit vel sollicitudin. In urna lacus, bibendum vitae blandit quis, porta et odio. Vivamus nec sagittis eros. Nullam consequat lorem in egestas pulvinar. Morbi feugiat est ex, vel viverra neque rhoncus ut.

            Donec sed ipsum neque. Donec vulputate faucibus tempor. Integer hendrerit neque ut mauris suscipit, eget imperdiet nibh convallis. Nam non laoreet ante, in congue sapien. Quisque semper faucibus mi, in molestie nulla. Sed sed ex pulvinar, rhoncus dolor vitae, vulputate mauris. Ut ultricies scelerisque mi sed ornare. Etiam viverra, lorem quis porta laoreet, leo dui malesuada tellus, a facilisis urna ex eu tellus. Pellentesque at erat quis urna dapibus lobortis. Aliquam erat volutpat.

            Proin diam libero, auctor ac lectus quis, condimentum malesuada dui. Quisque iaculis, ex gravida accumsan tempus, ligula nisl rutrum lectus, et laoreet enim sapien sit amet libero. Nullam accumsan augue tempor felis tempor tincidunt. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis at ex id orci volutpat auctor in eget lectus. Aliquam erat volutpat. Nam feugiat massa velit, vel placerat sapien interdum id. Nam mi orci, efficitur eu odio non, gravida molestie ante.

            Curabitur tempus, eros id finibus feugiat, urna orci vestibulum dui, eu maximus nunc nisl quis risus. Fusce dignissim ligula augue, viverra lacinia nulla consectetur quis. Aliquam aliquet id neque maximus vehicula. Sed massa metus, interdum vel lectus non, hendrerit pellentesque massa. Curabitur placerat, sapien eu suscipit lacinia, justo leo pellentesque arcu, ac semper dui massa vel nunc. Donec vitae suscipit mauris, eget efficitur massa. Morbi fermentum dui in tellus tristique faucibus. Nullam quis scelerisque justo. Vestibulum ante ipsum, accumsan et fermentum a, fringilla quis arcu. Mauris interdum ipsum egestas faucibus lobortis. Pellentesque accumsan velit ut odio luctus, ac rutrum sapien blandit. Maecenas malesuada purus vitae nisl sagittis, non maximus risus pellentesque. Vivamus tempus iaculis elit. Integer et consequat eros.
            """;
        #endregion

        byte[] rsByteArray = Encoding.Default.GetBytes(text);
        fs.Write(rsByteArray, 0, rsByteArray.Length);
        fs.Position = 0;

        byte[] data = new byte[rsByteArray.Length];
        for (int i = 0; i < rsByteArray.Length; i++)
        {
            data[i] = (byte)fs.ReadByte();
        }

        Console.WriteLine(Encoding.Default.GetString(data));
        fs.Close();
    }


    public static void Main(String[] args)
    {
        string folderPath = @"C:\Users\murat\Desktop\RNET102\Introduction\SystemIOExample\SystemIOExample\Files";
        string filePath = @"C:\Users\murat\Desktop\RNET102\Introduction\SystemIOExample\SystemIOExample\Files\example1.txt";
        string fileStreamPath = @"C:\Users\murat\Desktop\RNET102\Introduction\SystemIOExample\SystemIOExample\Files\streamFile.txt";

        // Belge yazma işlemi
        WriteAllLines(filePath);

        // Belge veri okuma işlemi
        ReadAllLines(filePath);

        // Belge bilgilerini alma
        FileInfo(folderPath);

        // Belge yazma işlemi
        FileStream(fileStreamPath);
    }
}