using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.Singleton;
public class SingletonExercice : IDemo
{
    public void Run()
    {
        var obj = new object();
        Console.WriteLine($"Is Singleton: {SingletonTester.IsSingleton(() => obj)}");
        Console.WriteLine($"Is Singleton: {SingletonTester.IsSingleton(() => new object())}");
    }

    public static class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var obj1 = func();
            Console.WriteLine(obj1.GetHashCode());
            var obj2 = func();
            Console.WriteLine(obj2.GetHashCode());
            return ReferenceEquals(obj1, obj2);
        }
    }
}
