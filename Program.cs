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
    }
}
