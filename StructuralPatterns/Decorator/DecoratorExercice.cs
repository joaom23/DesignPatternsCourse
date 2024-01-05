namespace DesignPatternsCourse.Decorator;

public class DecoratorExercice : IDemo
{
    public void Run()
    {
        var d = new Dragon();
        d.Age = 1;
        Console.WriteLine(d.Crawl());
        Console.WriteLine(d.Fly());
        Console.WriteLine(d);
    }

    public class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class Dragon // no need for interfaces
    {
        private Bird bird = new();
        private Lizard lizard = new Lizard();

        public Dragon()
        {

        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                bird.Age = value;
                lizard.Age = value;
                age = value;
            }
        }


        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return lizard.Crawl();
        }

        public override string ToString()
        {
            return $"Age: {age}";
        }
    }
}
