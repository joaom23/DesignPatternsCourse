namespace DesignPatternsCourse.Builder.FunctionalBuilder;
public partial class FunctinalBuilderDemo
{
    public class Person
    {
        public string Name, Position, LastName;

        public override string ToString()
        {
            return $"Name: {Name}, Last name: {LastName}, Position: {Position}";
        }
    }
}
