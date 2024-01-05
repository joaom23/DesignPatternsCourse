using System.Collections;
using static DesignPatternsCourse.Composite.CompositeExercice;

namespace DesignPatternsCourse.Composite;

public static class ExtensionMethods
{
    public static int Sum(this List<IValueContainer> containers)
    {
        int result = 0;
        foreach (var c in containers)
            foreach (var i in c)
                result += i;
        return result;
    }
}

public class CompositeExercice : IDemo
{
    public void Run()
    {
        var singleValue = new SingleValue(1);
        var multipleValues = new ManyValues(new List<int> { 1, 2, 3 });
        var allValues = new ManyValues(singleValue, multipleValues);

        Console.WriteLine($"Single value: {singleValue.Sum()}");
        Console.WriteLine($"Multiple values: {multipleValues.Sum()}");
        Console.WriteLine($"All values: {allValues.Sum()}");
    }

    public interface IValueContainer : IEnumerable<int>
    {
    }

    public class SingleValue : IValueContainer
    {
        public int Value;

        public SingleValue(int value)
        {
            Value = value;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ManyValues : List<int>, IValueContainer
    {
        public ManyValues(List<int> values)
        {
            foreach (var item in values)
            {
                Add(item);
            }
        }

        public ManyValues(params IValueContainer[] values)
        {
            foreach (var value in values)
            {
                foreach (var number in value)
                {
                    Add(number);
                }
            }
        }
    }
}
