﻿namespace DesignPatternsCourse.Builder.FunctionalBuilder;
public partial class FunctinalBuilderDemo
{
    public sealed class PersonBuilder
    {
        public readonly List<Action<Person>> Actions = new();

        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        public Person Build()
        {
            var p = new Person();
            Actions.ForEach(a => a(p));
            return p;
        }
    }
}
