using System.Xml;

class Program
{
    static void Main()
    {
        //Local file
        var caminhoUsuarioLocal = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string nomeArquivo = "";//Nome do arquivo mais .xml vai aqui
        var caminhoArquivo = $"{caminhoUsuarioLocal}\\Downloads\\{nomeArquivo}";

        XmlDocument xmlDoc = new();
        xmlDoc.Load(caminhoArquivo);

        XmlNodeList nomeProd = xmlDoc.GetElementsByTagName("xProd");
        XmlNodeList valorProd = xmlDoc.GetElementsByTagName("vProd");
        XmlNodeList valorICMS = xmlDoc.GetElementsByTagName("vICMS");
        XmlNodeList valorIPI = xmlDoc.GetElementsByTagName("vIPI");

        string tagName = "prod";
        int count = xmlDoc.GetElementsByTagName(tagName).Count;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{nomeProd[i]?.InnerText} -> {valorProd[i]?.InnerText}");
        }

        Console.WriteLine($@"Valor ICMS: {valorICMS[0]?.InnerText}");
        Console.WriteLine($"Valor IPI: {valorIPI[0]?.InnerText}");


    }

}
