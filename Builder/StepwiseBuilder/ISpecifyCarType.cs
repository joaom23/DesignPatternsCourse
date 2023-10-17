namespace DesignPatternsCourse.Builder.StepwiseBuilder;
public partial class StepwiseBuilderDemo
{
    public interface ISpecifyCarType
    {
        public ISpecifyWheelSize OfType(CarType type);
    }
}
