﻿namespace DesignPatternsCourse.Factories.AbstractFactory;

public interface IHotDrink
{
    void Consume();
}

internal class Tea : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This tea is nice but I'd prefer it with milk.");
    }
}

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This coffee is delicious!");
    }
}

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}

internal class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Put in tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
        return new Tea();
    }
}

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
        return new Coffee();
    }
}

public class HotDrinkMachine
{
    public enum AvailableDrink // violates open-closed
    {
        Coffee, Tea
    }

    private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
      new Dictionary<AvailableDrink, IHotDrinkFactory>();

    private List<Tuple<string, IHotDrinkFactory>> namedFactories =
      new List<Tuple<string, IHotDrinkFactory>>();

    public HotDrinkMachine()
    {
        //foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //{
        //  var factory = (IHotDrinkFactory) Activator.CreateInstance(
        //    Type.GetType("DotNetDesignPatternDemos.Creational.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
        //  factories.Add(drink, factory);
        //}

        var test = typeof(HotDrinkMachine).Assembly.GetTypes();
        foreach (var t in test)
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                namedFactories.Add(Tuple.Create(
                  t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
            }
        }
    }

    public IHotDrink MakeDrink()
    {
        Console.WriteLine("Available drinks");
        for (var index = 0; index < namedFactories.Count; index++)
        {
            var tuple = namedFactories[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string s;
            if ((s = Console.ReadLine()) != null
                && int.TryParse(s, out int i)
                && i >= 0
                && i < namedFactories.Count)
            {
                Console.Write("Specify amount: ");
                s = Console.ReadLine();
                if (s != null
                    && int.TryParse(s, out int amount)
                    && amount > 0)
                {
                    return namedFactories[i].Item2.Prepare(amount);
                }
            }
            Console.WriteLine("Incorrect input, try again.");
        }
    }

    //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    //{
    //  return factories[drink].Prepare(amount);
    //}
}


