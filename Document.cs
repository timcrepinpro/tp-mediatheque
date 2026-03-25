class Document
{
    protected int id {get; set;}
    protected string titre {get; set;}
    protected bool disponible {get; set;}

    public Document(int id, string titre)
    {
        this.id = id;
        this.titre = titre;
       
        this.disponible = true;
    }
    public void Afficher()
    {
        string dispo = disponible ? "disponible" : "indisponible";
        Console.WriteLine($"le livre id numero  {id} et titre  {titre} est {dispo}");
    }
    public virtual string ToString()
    {
        return $"{id}{titre}{disponible}";
    }
    
}
        
    
