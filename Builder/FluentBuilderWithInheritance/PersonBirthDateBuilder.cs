namespace DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
public partial class InheritanceBuilderDemo
{
    public class PersonBirthDateBuilder<SELF>
      : PersonJobBuilder<PersonBirthDateBuilder<SELF>>
      where SELF : PersonBirthDateBuilder<SELF>
    {
        public SELF Born(DateOnly dateOfBirth)
        {
            person.DateOfBirth = dateOfBirth;
            return (SELF)this;
        }
    }
}
