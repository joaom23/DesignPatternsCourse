namespace DesignPatternsCourse.Factories.PointExample;
public class PointFactory
{
    public static Point NewCartesianPoint(float x, float y)
    {
        return new Point(x, y); // needs to be public
    }
}
