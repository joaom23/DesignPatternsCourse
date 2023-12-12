namespace DesignPatternsCourse.Behavioral_Patterns.MediatorPattern;
public class MediatorExercice : IDemo
{
    public void Run()
    {
        var mediator = new Mediator();
        var person1 = new Participant(mediator, "person1");
        var person2 = new Participant(mediator, "person2");

        person1.Say(1);
        person2.Say(2);

        person1.PrintValue();
        person2.PrintValue();
    }

    public class Participant
    {
        private Mediator _mediator;
        private string Name; 
        public int Value { get; set; }

        public Participant(Mediator mediator, string name)
        {
            _mediator = mediator;
            _mediator.Add(this);
            Name = name;
        }

        public void Say(int n)
        {
            _mediator.BroadCast(n, this);
        }

        public void PrintValue()
        {
            Console.WriteLine($"{Name} has {Value} points!");
        }
    }

    public class Mediator
    {
        private List<Participant> participants = new();

        public void Add(Participant p)
        {
            participants.Add(p);
        }

        public void BroadCast(int n, Participant self) 
        {
            foreach (var p in participants)
            {
                if(p.GetHashCode() != self.GetHashCode())
                {
                    p.Value += n;
                }
            }
        }
    }

    public class ParticipantWithEvent
    {
        private readonly MediatorWithEvent mediator;
        public int Value { get; set; }

        public ParticipantWithEvent(MediatorWithEvent mediator)
        {
            this.mediator = mediator;
            mediator.Alert += Mediator_Alert;
        }

        private void Mediator_Alert(object sender, int e)
        {
            if (sender != this)
                Value += e;
        }

        public void Say(int n)
        {
            mediator.Broadcast(this, n);
        }
    }

    public class MediatorWithEvent
    {
        public void Broadcast(object sender, int n)
        {
            Alert?.Invoke(sender, n);
        }

        public event EventHandler<int> Alert;
    }
}
