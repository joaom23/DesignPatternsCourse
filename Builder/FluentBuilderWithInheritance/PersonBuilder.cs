namespace DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
public partial class InheritanceBuilderDemo
{
    public abstract class PersonBuilder
    {
        protected Person person = new();

        public Person Build()
        {
            return person;
        }
    }
}
