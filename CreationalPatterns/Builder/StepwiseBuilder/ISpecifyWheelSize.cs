namespace DesignPatternsCourse.Builder.StepwiseBuilder;
public partial class StepwiseBuilderDemo
{
    public interface ISpecifyWheelSize
    {
        public IBuildCar WithWheels(int size);
    }
}
