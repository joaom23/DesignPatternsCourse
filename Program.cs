using DesignPatternsCourse;
using DesignPatternsCourse.Adapter;
using DesignPatternsCourse.Behavioral_Patterns.ChainOfResponsibility;
using DesignPatternsCourse.Behavioral_Patterns.Command;
using DesignPatternsCourse.Behavioral_Patterns.MediatorPattern;
using DesignPatternsCourse.Bridge;
using DesignPatternsCourse.Builder;
using DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
using DesignPatternsCourse.Builder.FunctionalBuilder;
using DesignPatternsCourse.Builder.NormalBuilder;
using DesignPatternsCourse.Builder.StepwiseBuilder;
using DesignPatternsCourse.Composite;
using DesignPatternsCourse.Decorator;
using DesignPatternsCourse.Facade;
using DesignPatternsCourse.Factories;
using DesignPatternsCourse.Factories.AbstractFactory;
using DesignPatternsCourse.Factories.BulkReplacement;
using DesignPatternsCourse.Factories.PointExample;
using DesignPatternsCourse.Flyweight;
using DesignPatternsCourse.Prototype;
using DesignPatternsCourse.Proxy;
using DesignPatternsCourse.Singleton;

class Program
{
    public static void Main(string[] args)
    {
        string showOptions = "opt";

        var options = new List<string>
        {
            "---Creational Patterns---\n",
            "---BUILDER---",
            "1 - Normal Builder",
            "2 - Builder with inheritance",
            "3 - Stepwise builder",
            "4 - Functional builder",
            "5 - Builder exercice",
            "-------------------------------------------------\n",
            "---Factories---",
            "6 - Point Example",
            "7 - Bulk Replacement",
            "8 - Abstract Factory",
            "9 - Factory exercice",
            "-------------------------------------------------\n",
            "---Prototype---",
            "10 - Prototype Inheritance",
            "11 - Prototype Serializer",
            "-------------------------------------------------\n",
            "---Singleton---",
            "12 - Singleton Exercice",
            "\n---Structural Patterns---\n",
            "---ADAPTER---",
            "13 - Adapter Exercice",
            "-------------------------------------------------\n",
            "---BRIDGE---",
            "14 - Bridge example",
            "15 - Bridge exercice",
            "-------------------------------------------------\n",
            "---COMPOSITE---",
            "16 - Composite Geometric Shapes",
            "17 - Composite Exercice",
            "-------------------------------------------------\n",
            "---DECORATOR---",
            "18 - Multiple Inheritance With Interfaces",
            "19 - Dynamic Decorator",
            "20 - Decorator Exercice",
            "-------------------------------------------------\n",
            "---FACADE---",
            "21 - Facade Exercice",
            "-------------------------------------------------\n",
            "---FLYWEIGHT---",
            "22 - Text formatter example",
            "23 - Flyweight Exercice",
            "-------------------------------------------------\n",
            "---PROXY---",
            "24 - Protection Proxy",
            "25 - Property Proxy",
            "26 - Value Proxy",
            "27 - Composite Proxy",
            "28 - Proxy Exercice",
            "-------------------------------------------------\n",
            "\n---Behavioral Patterns---\n",
            "---CHAIN OF RESPONSIBILITY---",
            "29 - Method chain",
            "30 - Broker chain",
            "31 - Chain of Responsibility exercice",
            "-------------------------------------------------\n",
            "--- COMMAND ---",
            "32 - Command with undo",
            "33 - Composite Command",
            "34 - Command Exercice",
            "-------------------------------------------------\n",
            "--- ITERATOR ---",
            "-------------------------------------------------\n",
            "--- MEDIATOR ---",
            "35 - Chat room exmaple",
            "36 - Event broker example",
            "37 - Mediator Exercice",
            "-------------------------------------------------\n",
            "--- MEMENTO ---",
            "38 - ",
            "-------------------------------------------------\n",
            "0 - Exit"
        };

        if (args != null && args.Length > 0)
        {
            if (args[0] == showOptions)
            {
                foreach (string option in options)
                {
                    Console.WriteLine(option);
                }

                return;
            }

            SelectClassToExecute(Convert.ToInt32(args[0]));
            return;
        }

        int keyNumber;

        do
        {
            Console.Clear();

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            var key = Console.ReadLine();

            bool parseSuccess = int.TryParse(key!.ToString(), out keyNumber);

            if (parseSuccess)
            {
                SelectClassToExecute(keyNumber);
            }
            else
            {
                Console.WriteLine("\nInvalid option. Press any key to continue...");
                Console.ReadLine();
                keyNumber = -1;
            }
        } while (keyNumber != 0);
    }

    private static void SelectClassToExecute(int key)
    {
        switch (key)
        {
            case 1:
                RunDemo(new BuilderDemo());
                break;

            case 2:
                RunDemo(new InheritanceBuilderDemo());
                break;

            case 3:
                RunDemo(new StepwiseBuilderDemo());
                break;

            case 4:
                RunDemo(new FunctinalBuilderDemo());
                break;

            case 5:
                RunDemo(new BuilderExercice());
                break;

            case 6:
                RunDemo(new PointeExampleDemo());
                break;

            case 7:
                RunDemo(new BulkReplacementDemo());
                break;

            case 8:
                RunDemo(new AbstractFactoryDemo());
                break;

            case 9:
                RunDemo(new FactoryExercice());
                break;

            case 10:
                RunDemo(new PrototypeInheritanceDemo());
                break;

            case 11:
                RunDemo(new PrototypeSerializerDemo());
                break;

            case 12:
                RunDemo(new SingletonExercice());
                break;

            case 13:
                RunDemo(new AdapterExercice());
                break;

            case 14:
                RunDemo(new BridgeExample());
                break;

            case 15:
                RunDemo(new BridgeExercice());
                break;

            case 16:
                RunDemo(new CompositeGeometricShapes());
                break;

            case 17:
                RunDemo(new CompositeExercice());
                break;

            case 18:
                RunDemo(new MultipleInheritanceWithInterfaces());
                break;

            case 19:
                RunDemo(new DynamicDecorator());
                break;

            case 20:
                RunDemo(new DecoratorExercice());
                break;

            case 21:
                RunDemo(new FacadeExercice());
                break;

            case 22:
                RunDemo(new TextFormatterExample());
                break;

            case 23:
                RunDemo(new FlyweightExercice());
                break;

            case 24:
                RunDemo(new ProtectionProxy());
                break;

            case 25:
                RunDemo(new PropertyProxy());
                break;

            case 26:
                RunDemo(new ValueProxy());
                break;

            case 27:
                RunDemo(new CompositeProxy());
                break;

            case 28:
                RunDemo(new ProxyExercice());
                break;

            case 29:
                RunDemo(new MethodChain());
                break;

            case 30:
                RunDemo(new BrokerChain());
                break;

            case 31:
                RunDemo(new ChainOfResponsibilityExercice());
                break;

            case 32:
                RunDemo(new CommandWithUndo());
                break;

            case 33:
                RunDemo(new CompositeCommand());
                break;

            case 34:
                RunDemo(new CommandExercice());
                break;

            case 35:
                RunDemo(new ChatRoomExample());
                break;

            case 36:
                RunDemo(new EventBrokerExample());
                break;

            case 37:
                RunDemo(new MediatorExercice());
                break;

            case 0:
                break;

            default:
                Console.WriteLine("\nInvalid option. Press any key to continue...");
                Console.ReadLine();
                break;
        }
    }

    private static void RunDemo(IDemo demo)
    {
        Console.Clear();
        demo.Run();
        Console.ReadLine();
    }
}





