using DesignPatternsCourse;
using DesignPatternsCourse.Adapter;
using DesignPatternsCourse.Bridge;
using DesignPatternsCourse.Builder;
using DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
using DesignPatternsCourse.Builder.FunctionalBuilder;
using DesignPatternsCourse.Builder.NormalBuilder;
using DesignPatternsCourse.Builder.StepwiseBuilder;
using DesignPatternsCourse.Composite;
using DesignPatternsCourse.Decorator;
using DesignPatternsCourse.Factories;
using DesignPatternsCourse.Factories.AbstractFactory;
using DesignPatternsCourse.Factories.BulkReplacement;
using DesignPatternsCourse.Factories.PointExample;
using DesignPatternsCourse.Prototype;
using DesignPatternsCourse.Singleton;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        var options = new List<string>
        {
            "---Creational Patterns---\n",
            "---BUILDER---",
            "1 - Normal Builder",
            "2 - Builder with inheritance",
            "3 - Stepwise builder",
            "4 - Functional builder",
            "5 - Builder exercice",
            "-------------\n",
            "---Factories---",
            "6 - Point Example",
            "7 - Bulk Replacement",
            "8 - Abstract Factory",
            "9 - Factory exercice",
            "-------------\n",
            "---Prototype---",
            "10 - Prototype Inheritance",
            "11 - Prototype Serializer",
            "-------------\n",
            "---Singleton---",
            "12 - Singleton Exercice",
            "\n---Structural Patterns---\n",
            "---ADAPTER---",
            "13 - Adapter Exercice",
            "\"-------------\n",
            "---BRIDGE---",
            "14 - Bridge example",
            "15 - Bridge exercice",
            "-------------\n",
            "---COMPOSITE---",
            "16 - Composite Geometric Shapes",
            "17 - Composite Exercice",
            "-------------\n",
            "---DECORATOR---",
            "18 - Multiple Inheritance With Interfaces",
            "-------------\n",
            "0 - Exit"
        };

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
                switch (keyNumber)
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

                    case 0:
                            break;

                        default:
                            Console.WriteLine("\nInvalid option. Press any key to continue...");
                            Console.ReadLine();
                            break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid option. Press any key to continue...");
                Console.ReadLine();
                keyNumber = -1;
            }
        } while (keyNumber != 0);
    }

    private static void RunDemo(IDemo demo)
    {
        Console.Clear();
        demo.Run();
        Console.ReadLine();
    }
}





