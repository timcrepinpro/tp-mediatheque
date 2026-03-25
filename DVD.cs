class DVD :Document
{
    protected string realisateur {get; set;}
    protected int duree {get; set;}
    public DVD(int id, string titre, bool disponible, string realisateur, int duree) : base(id, titre, disponible)
    {
        this.id = id;
        this.titre = titre;
        this.disponible = disponible;
        this.realisateur = realisateur;
        this.duree = duree;

    }
    public string getrealisateur()
    {
        return realisateur;
    }
    public int getduree()
    {
        return duree;
    }
    public void setrealisateur(string realisateur)
    {
        this.realisateur = realisateur;
    }
    public void setduree(int duree)
    {
        this.duree = duree;
    }
    public override string ToString()
    {
        return base.ToString() +$"{realisateur}{duree}";
    }
    public override void Afficher()
    {
        base.Afficher();
        string dispo = disponible ? "disponible" : "indisponible";
        Console.WriteLine($"le livre id numero  {id} et titre  {titre} est {dispo}");
    }
}

