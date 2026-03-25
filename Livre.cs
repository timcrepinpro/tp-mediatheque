class Livre :Document
{
    protected string auteur{get; set;}
    protected int nombrepages {get;set;}
    public Livre(int id, string titre, bool disponible, string auteur, int nombrepages) : base(id, titre, disponible)
    {
        this.auteur = auteur;
        this.nombrepages = nombrepages;

    }
    public string getauteur()
    {
        return auteur;
    }
    public int getnombrepages()
    {
        return nombrepages;
    }
    public void setauteur(string auteur)
    {
        this.auteur = auteur;
    }
    public void setnombrepages(int nombrepages)
    {
        this.nombrepages = nombrepages;
    }
    public string ToString()
    {
        return $"{id}{titre}{disponible}{auteur}{nombrepages}";
    }
    public override void Afficher()
    {
        base.Afficher();
        
        Console.WriteLine($"se livre a etai fait par {auteur} et contient {nombrepages} pages");
    }
    
}
