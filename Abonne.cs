class Abonne
{
    protected int id {get; set;}
    protected string nom {get; set;}

    public Abonne(int id, string nom)
    {
        if(nom != null || nom != "")
        {
            this.id = id;
            this.nom = nom;
        }
    }
    public int getit()
    {
        return id;
    }
    public string getnom()
    {
        return nom;
    }
    public void setid(int id)
    {
        this.id = id;
    }
    public void setnom(string nom)
    {
        this.nom = nom;
    }
    
    string ToString()
    {
        return $"{id}{nom}";
    }
    public void Afficher()
    {
        
        Console.WriteLine($"l'id de lutilisateur est {id} et son nom est {nom}");
    }
    
    
}