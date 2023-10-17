namespace DesignPatternsCourse.Builder.StepwiseBuilder;
public partial class StepwiseBuilderDemo : IDemo
{
    public void Run()
    {
        var car = CarBuilder.Create()
        .OfType(CarType.Crossover)
        .WithWheels(18)
        .Build();

        Console.WriteLine(car);
    }
}
