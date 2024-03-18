class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("in main");

        Encapsulation e = new Encapsulation();
        e.Name = "Enes A. alıcı";

        Console.WriteLine(e.Name);
    }
}
class Encapsulation
{
    private string name;
    public string Name
    {
        get { return "sayın " + name; }
        set { name = value; }
    }
}