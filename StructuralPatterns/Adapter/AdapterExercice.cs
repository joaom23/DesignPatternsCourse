using static DesignPatternsCourse.Adapter.AdapterExercice;

namespace DesignPatternsCourse.Adapter;

public static class ExtensionMethods
{
    public static int Area(this IRectangle rc)
    {
        return rc.Width * rc.Height;
    }
}

public class AdapterExercice : IDemo
{
    public class Square
    {
        public int Side;
    }

    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square _square;
        public int Width => _square.Side;
        public int Height => _square.Side;

        public SquareToRectangleAdapter(Square square)
        {
            _square = square;
        }
    }

    public void Run()
    {
        var square = new Square
        {
            Side = 11
        };

        IRectangle squareAdapter = new SquareToRectangleAdapter(square);

        Console.WriteLine($"Area of rectangle: {squareAdapter.Area()}");
    }
}
