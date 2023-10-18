using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.Factories;
public class FactoryExercice : IDemo
{
    public void Run()
    {

        for (int i = 0; i < 10; i++)
        {
            var factory = new PersonFactory();
            var newPerson = factory.CreatePerson("Joao");
            Console.WriteLine($"{newPerson.Id}: {newPerson.Name}");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class PersonFactory
    {
        public static int idTracking;

        public Person CreatePerson(string name)
        { 
            var newPerson = new Person(idTracking, name);
            idTracking++;
            return newPerson;
        }
    }
}
