using System.Security.Cryptography;

namespace DesignPatternsCourse.Proxy;

public class ProxyExercice : IDemo
{
    public void Run()
    {
        var person = new Person() { Age = 15 };

        var responsiblePerson = new ResponsiblePerson(person);
        Console.WriteLine(responsiblePerson.Drive());
        Console.WriteLine(responsiblePerson.Drink());
        Console.WriteLine(responsiblePerson.DrinkAndDrive());

        Console.WriteLine(person.Drive());
        Console.WriteLine(person.Drink());
        Console.WriteLine(person.DrinkAndDrive());
    }

    public class Person : IPerson
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson : IPerson
    {
        private readonly Person _person;

        public ResponsiblePerson(Person person)
        {
            _person = person;
        }

        public int Age 
        {
            get => _person.Age;
            set => _person.Age = value;
        }

        public string Drink()
        {
            if(Age > 18)
            {
               return _person.Drink();
            }

            return "too young";
        }

        public string DrinkAndDrive()
        {
            return "Dead";
        }

        public string Drive()
        {
            if(Age > 16)
            {
                return _person.Drive();
            }

            return "too young";
        }
    }

    public interface IPerson
    {
        int Age { get; set; }
        public string Drink();
        public string Drive();
        public string DrinkAndDrive();
    }
}
