namespace DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
public partial class InheritanceBuilderDemo : IDemo
{
    public void Run()
    {
        var me = Person.New
        .WorksAsA("Miguell")
        .Born(new DateOnly(1999, 8, 13))
        .Called("Joao")
        .Build();
        Console.WriteLine(me);
    }
}
