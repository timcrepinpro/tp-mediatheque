class Document
{
    protected int id {get;set;}
    protected string titre {get; set;}
    protected bool disponible {get; set;}

    public Document(int id, string titre ,bool disponible)
    {
        this.id = id;
        this.titre = titre;
        this.disponible = true;
    }
    public virtual void Afficher()
    {
        string dispo = disponible ? "disponible" : "indisponible";
        Console.WriteLine($"le livre id numero  {id} et titre  {titre} est {dispo}");
    }
    public virtual string ToString()
    {
        return $"{id}{titre}{disponible}";
    }
    public int GetId()
    {
        return id;
    }
    public string GetTitre()
    {
        return titre;
    }
    public bool GetDisponible()
    {
        return disponible;
    }
    public void SetId(int id)
    {
        this.id = id;
    }
    public void SetTitre(string titre)
    {
        this.titre = titre;
    }
    public void SetDisponible(bool disponible)
    {
        this.disponible = disponible;
    }
    public Document(bool disponible)
    {
        this.disponible = disponible;
    }
    
}
        
    
