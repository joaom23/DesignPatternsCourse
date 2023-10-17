namespace DesignPatternsCourse.Builder.FluentBuilderWithInheritance;
public partial class InheritanceBuilderDemo
{
    public class Person
    {
        public string Name;

        public string Position;

        public DateOnly DateOfBirth;

        public class Builder : PersonBirthDateBuilder<Builder>
        {
            internal Builder() { }
        }

        public static Builder New => new();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}, {nameof(DateOfBirth)}: {DateOfBirth}";
        }
    }
}
