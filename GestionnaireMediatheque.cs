class GestionnaireMediatheque
{
    protected List<Document> documents ;
    protected List<Abonne> abonnes;
    protected List<Emprunt> emprunt;
    protected Dictionary<int , string> abonnee ; 

    public GestionnaireMediatheque(Document document,Abonne abonne,Emprunt emprunt, Abonne abonnes)
    {
        this.documents = new List<Document>();
        this.documents.Add(document);
        this.abonnes = new List<Abonne>();
        this.abonnes.Add(abonne);
        this.emprunt = new List<Emprunt>();
        this.emprunt.Add(emprunt);
    }
    public GestionnaireMediatheque()
    {
        this.documents = new List<Document>();
        this.abonnes = new List<Abonne>();
        this.emprunt = new List<Emprunt>();
        this.abonnee = new Dictionary<int, string>();
    }

    public void AjouterDocument(Document document)
    {
        this.documents.Add(document);
    }
    public void AjouterEmprunt(Emprunt emprunt)
    {
        this.emprunt.Add(emprunt);
    }
    public void AfficherDocument()
    {
        foreach (Document document in documents)
        {
            document.Afficher();
        }
    }
    public void AfficherAbonne()
    {
        foreach (Abonne abonnes in abonnes)
        {
            abonnes.Afficher();
        }
    }

    public void AfficherEmprunt()
    {
        foreach (Emprunt emprunt in this.emprunt)
        {
            emprunt.Afficher();
        }
    }

    public void ChercherAbonneParId()
    {
        
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
}