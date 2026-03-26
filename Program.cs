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

        try
        {
        
            Dictionary<int , string> abonnee = new Dictionary<int , string>();
            abonnee.Add(1,"mathieu merrio");
            abonnee.Add(2,"jonathan zablot");
            abonnee.Add(3,"alex colpin");
        
            Console.WriteLine("quelle id chercher");
            int rechercher = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, string> paire in abonnee)
            {
                if(paire.Key == rechercher)
                {
                    Console.WriteLine($"{paire.Key}: {paire.Value}");
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            
        }

        Dictionary<int , string> empreint = new Dictionary<int , string>();
        empreint.Add(1,"mathieu merrio");
        empreint.Add(2,"jonathan zablot");
        empreint.Add(3,"alex colpin");
        foreach (KeyValuePair<int, string> paire in empreint)
        {
        
            Console.WriteLine($"{paire.Key}: {paire.Value}");
            
        }
        
   
        
    }
}


// gaillard quentin richard robert