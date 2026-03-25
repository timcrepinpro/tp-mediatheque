class Emprunt
{
    protected int id {get; set;}
    protected Document document {get; set;}
    protected Abonne abonne {get; set;}
    protected DateTime dateEmprunt {get; set;}
    protected DateTime dateRetourprevu {get; set;}

    public Emprunt(int id, Document document, Abonne abonne, DateTime dateEmprunt, DateTime dateRetourprevu)
    {
        if(id != null || id > 0 || document.GetDisponible() == true)
        {

            this.id = id;
            this.document = document;
            this.abonne = abonne;
            this.dateEmprunt = dateEmprunt;
            this.dateRetourprevu = dateRetourprevu;
        }
    }
    public void Emprunter()
    {


    }
    public void Afficher()
    {
        Console.WriteLine();
    }
    public string ToString()
    {
        return $"{id}{document}{abonne}{dateEmprunt}{dateRetourprevu}";
    }
    public int getid()
    {
        return id;
    }
    public Document getdocument()
    {
        return document;
    }
    public Abonne getabonne()
    {
        return abonne;
    }
    public DateTime getdateEmprunt()
    {
        return dateEmprunt;
    }
    public DateTime getdateRetourprevu()
    {
        return dateRetourprevu;
    }
    public void setid(int id)
    {
        this.id = id;
    }
    public void setdocument(Document document)
    {
        this.document = document;
    }
    public void setabonne(Abonne abonne)
    {
        this.abonne = abonne;
    }
    public void setdateEmprunt(DateTime dateEmprunt)
    {
        this.dateEmprunt = dateEmprunt;
    }
    public void setdateRetourprevu(DateTime dateRetourprevu)
    {
        this.dateRetourprevu = dateRetourprevu;
    }
    public void CalculerRetard(DateTime rendu)
    {
        if (DateTime.TryParse(rendu.ToString(), out DateTime d))
        {
            Console.WriteLine(d);
            Console.WriteLine(this.dateRetourprevu-d);
        }
    }
    public void EstEnRetard(DateTime rendu)
    {
        if (DateTime.TryParse(rendu.ToString(), out DateTime d))
        {
            if(d > this.dateRetourprevu)
            {
                Console.WriteLine("lempreinteur est en retard");
            }
        }
    }
    

}
