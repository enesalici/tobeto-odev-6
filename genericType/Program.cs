class Program
{

    static void Main(string[] args)
    {
        Person<int> generic = new Person<int>();
        generic.id = 1;
        generic.fullName = "Enes A. Alıcı";
        string x = "id: " + generic.id.ToString() + ", fullName: " + generic.fullName;
        Console.WriteLine("generic kullanımı böyle:: " + x);
    }
    class Person<T>
    {
        public T id { get; set; }
        public string fullName { get; set; }
    }
}