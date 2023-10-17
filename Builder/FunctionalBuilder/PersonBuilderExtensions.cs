using static DesignPatternsCourse.Builder.FunctionalBuilder.FunctinalBuilderDemo;

namespace DesignPatternsCourse.Builder.FunctionalBuilder;

public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAsA
      (this PersonBuilder builder, string position)
    {
        builder.Actions.Add(p =>
        {
            p.Position = position;
        });
        return builder;
    }

    public static PersonBuilder LastName
      (this PersonBuilder builder, string lastName)
    {
        builder.Actions.Add(p =>
        {
            p.LastName = lastName;
        });
        return builder;
    }
}

