namespace DesignPatternsCourse.Factories.PointExample;
internal class PointeExampleDemo : IDemo
{
    public void Run()
    {
        var p1 = new Point(2, 3, Point.CoordinateSystem.Cartesian);
        var origin = Point.Origin;

        var p2 = Point.Factory.NewCartesianPoint(1, 2);
    }
}
