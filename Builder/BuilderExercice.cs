using System.Drawing;
using System.Text;

namespace DesignPatternsCourse.Builder;
public class BuilderExercice : IDemo
{
    public void Run()
    {
        var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
        Console.WriteLine(cb);
    }

    public class CodeBuilder
    {
        private StringBuilder code;

        public CodeBuilder(string className)
        {
            code = new StringBuilder();
            code.AppendLine($"public class {className}");
            code.AppendLine("{");
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            code.AppendLine($"  public {fieldType} {fieldName};");
            return this;
        }

        public override string ToString()
        {
            code.AppendLine("}");
            return code.ToString();
        }
    }
}
