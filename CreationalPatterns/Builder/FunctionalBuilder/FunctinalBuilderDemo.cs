namespace DesignPatternsCourse.Builder.FunctionalBuilder;
public partial class FunctinalBuilderDemo : IDemo
{
    public void Run()
    {
        var pb = new PersonBuilder();
        var person = pb.Called("Joao").WorksAsA("Programmer").LastName("Fernandes").Build();

        Console.WriteLine(person);
    }
}
