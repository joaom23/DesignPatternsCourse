namespace DesignPatternsCourse.Builder.NormalBuilder;
public class BuilderDemo : IDemo
{
    public void Run()
    {
        // ordinary non-fluent builder
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello");
        builder.AddChild("li", "world");
        Console.WriteLine(builder.ToString());

        // fluent builder
        builder.Clear(); // disengage builder from the object it's building, then...
        builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
        Console.WriteLine(builder);
    }
}
