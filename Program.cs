using DesignPatternsCourse;
using DesignPatternsCourse.Builder;
using DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
using DesignPatternsCourse.Builder.FunctionalBuilder;
using DesignPatternsCourse.Builder.NormalBuilder;
using DesignPatternsCourse.Builder.StepwiseBuilder;
using DesignPatternsCourse.Factories;
using DesignPatternsCourse.Factories.AbstractFactory;
using DesignPatternsCourse.Factories.BulkReplacement;
using DesignPatternsCourse.Factories.PointExample;
using DesignPatternsCourse.Prototype;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        var options = new List<string>
        {
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
            "---Factories---",
            "10 - Prototype Inheritance",
            "11 - Prototype Serializer",
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





