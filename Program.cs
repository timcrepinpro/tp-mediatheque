namespace tp_mediatheque;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Livre livre1 = new Livre (1,"jcp",true,"mathieu merrio",89);
        livre1.Afficher();
        livre1.ToString();
        DVD dvd1 = new DVD (2,"jcp",true,"mathieu merrio",89);
        dvd1.Afficher();
        dvd1.ToString();

        List<Document> documents = new List<Document>
        {
            new Livre (1,"jcp",true,"mathieu merrio",89),
            new DVD (2,"auqune idée",true,"jonathan zablot",89)
        };
        foreach (Document document in documents)
        {
            if(document is Livre livre)
            {
                livre.Afficher();
            }
            if(document is DVD dvd)
            {
                dvd.Afficher();
            }
            else
            {
                document.Afficher();
            }
        }

        List<Abonne> abonnes = new List<Abonne>
        {
            new Abonne (1,"mathieu merrio"),
            new Abonne (2,"jonathan zablot"),
            new Abonne (3,"alex colpin")
        };
        foreach (Abonne abonne in abonnes)
        {
            abonne.Afficher();
        
        }
            
        
    }
}
