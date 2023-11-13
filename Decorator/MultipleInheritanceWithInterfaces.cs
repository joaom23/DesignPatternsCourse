namespace DesignPatternsCourse.Decorator;

public class MultipleInheritanceWithInterfaces : IDemo
{
    public void Run()
    {
        var d = new Dragon();
        d.Crawl();
        d.Fly();
        d.Weight = 100;
    }

    public interface IAnimal
    {
        int Weight { get; set; }
    }

    public interface IBird : IAnimal
    {
        void Fly();
    }

    public class Bird : IBird
    {
        public int Weight { get; set; }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    public interface ILizard : IAnimal
    {
        void Crawl();
    }

    public class Lizard : ILizard
    {
        public int Weight { get; set; }

        public void Crawl()
        {
            Console.WriteLine("Crawl");
        }
    }

    public class Dragon : IBird, ILizard
    {
        private Bird bird;
        private Lizard lizard;
        private int wheight;
        public Dragon()
        {
            bird = new Bird();
            lizard = new Lizard();
        }

        public Dragon(Bird bird, Lizard lizard)
        {
            this.bird = bird ?? throw new ArgumentNullException(paramName: nameof(bird));
            this.lizard = lizard ?? throw new ArgumentNullException(paramName: nameof(lizard));
        }

        public int Weight { get => wheight; set => wheight = value; }

        public void Crawl()
        {
            lizard.Crawl();
        }

        public void Fly()
        {
            bird.Fly();
        }
    }
}
