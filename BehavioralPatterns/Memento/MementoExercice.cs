using System.Text;

namespace DesignPatternsCourse.BehavioralPatterns.Memento;

public class MementoExercice : IDemo
{
    public void Run()
    {
        var tm = new TokenMachine();
        var m = tm.AddToken(123);
        tm.AddToken(456);
        tm.Revert(m);

        Console.WriteLine(tm);
    }

    public class Token
    {
        public int Value = 0;

        public Token(int value)
        {
            this.Value = value;
        }
    }

    public class Memento
    {
        public List<Token> Tokens = new List<Token>();
    }

    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();

        public Memento AddToken(int value)
        {
            return AddToken(new Token(value));
        }

        public Memento AddToken(Token token)
        {
            Tokens.Add(token);
            var m = new Memento();
            // a rather roundabout way of cloning
            m.Tokens = Tokens.Select(t => new Token(t.Value)).ToList();
            return m;
        }

        public void Revert(Memento m)
        {
            Tokens = m.Tokens.Select(mm => new Token(mm.Value)).ToList();
        }

        public override string ToString()
        {
            var count = 0;
            var sb = new StringBuilder();
            foreach (var item in Tokens)
            {
                sb.AppendLine($"Token{count}, value: {item.Value}");
            }

            return sb.ToString();
        }
    }
}
