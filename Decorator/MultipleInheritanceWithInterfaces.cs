namespace DesignPatternsCourse.Decorator;

public class MultipleInheritanceWithInterfaces : IDemo
{
    public void Run()
    {
        
    }

    public class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    public class Lizard
    {
        public void Crawl()
        {
            Console.WriteLine("Crawl");
        }
    }

    public class Dragon 
    {
        private Bird bird;
        private Lizard lizard;

        public Dragon(Bird bird, Lizard lizard)
        {
            this.bird = bird ?? throw new ArgumentNullException(paramName: nameof(bird));
            this.lizard = lizard ?? throw new ArgumentNullException(paramName: nameof(lizard));
        }

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
