namespace DesignPatternsCourse.Factories.AbstractFactory;
internal class AbstractFactoryDemo : IDemo
{
    public void Run()
    {
        var machine = new HotDrinkMachine();
        //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
        //drink.Consume();

        IHotDrink drink = machine.MakeDrink();
        drink.Consume();
    }
}
