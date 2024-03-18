class Program
{
    // Polimorfizm inheritanceın bir sonucudur.

    static void Main(string[] args)
    {
        //örnek 1
        B b = new B();
        b.id = 1;
        b.name = "Enes";
        Console.WriteLine("id:" + b.id + " name:" + b.name);
        //
        Console.WriteLine("___________________________________________");
        Console.WriteLine("___________________________________________");
        //örnek 2
        Sekiller sekiller = new Sekil1();
        sekiller.Ciz();
        //
        Console.WriteLine("___________________________________________");
        Console.WriteLine("___________________________________________");
        //örnek 3
        MoveManager moveManager = new MoveManager();
        moveManager.Move();

        moveManager = new Left();
        moveManager.Move();

        moveManager = new Right();
        moveManager.Move();

        moveManager = new Back();
        moveManager.Move();

        moveManager = new Forward();
        moveManager.Move();
    }

    //örnek 1
    class A
    {
        public int id { get; set; }
    }

    class B : A
    {
        public string name { get; set; }
    }

    //örnek 2
    class Sekiller
    {
        public virtual void Ciz()
        {
            Console.WriteLine("resim çiziliyor");
        }
    }

    class Sekil1 : Sekiller
    {
        public override void Ciz()
        {
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Lütfen çizmek istediğiniz resmi girin:");
            string resim = Console.ReadLine()!;
            Console.WriteLine("Çiziliyor: " + resim);
        }
    }


    class Left : MoveManager
    {
        public override void Move()
        {
            Console.WriteLine("karakter sola yürüyor");
        }
    }
    class Right : MoveManager
    {
        public override void Move()
        {
            Console.WriteLine("karakter sağa yürüyor");
        }
    }
    class Back : MoveManager
    {
        public override void Move()
        {
            Console.WriteLine("karakter geri yürüyor");
        }
    }
    class Forward : MoveManager
    {
        public override void Move()
        {
            Console.WriteLine("karakter ileri yürüyor");
        }
    }

    class MoveManager
    {
        public virtual void Move()
        {
            Console.WriteLine("karakter yürüyor");
        }
    }


}