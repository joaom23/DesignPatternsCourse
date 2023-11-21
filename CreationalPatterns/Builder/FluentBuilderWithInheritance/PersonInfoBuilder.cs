namespace DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
public partial class InheritanceBuilderDemo
{
    public class PersonInfoBuilder<SELF> : PersonBuilder
      where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
}
