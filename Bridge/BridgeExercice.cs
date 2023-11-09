namespace DesignPatternsCourse.Bridge;

public class BridgeExercice : IDemo
{
    public void Run()
    {
        Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
        new Triangle(new RasterRenderer()).Test();
        // returns "Drawing Triangle as pixels" 
    }

    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs => "vector";
    }

    public abstract class Shape
    {
        public string Name { get; set; } = string.Empty;
        private readonly IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public void Test()
        {
            Console.WriteLine($"Oi, eu sou um {Name}");
        }

        public override string ToString()
        {
            return $"Drawing {Name} as {_renderer.WhatToRenderAs}";
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }
}
