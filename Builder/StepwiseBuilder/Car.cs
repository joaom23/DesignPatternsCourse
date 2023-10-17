namespace DesignPatternsCourse.Builder.StepwiseBuilder;
public partial class StepwiseBuilderDemo
{
    public class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString()
        {
            return $"Car type: {Type}, Wheel size: {WheelSize}";
        }
    }
}
