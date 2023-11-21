using static DesignPatternsCourse.Prototype.PrototypeSerializer;

namespace DesignPatternsCourse.Prototype;
public class PrototypeSerializerDemo : IDemo
{
    public void Run()
    {
        Foo foo = new Foo { Stuff = 42, Whatever = "abc" };

        //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
        Foo foo2 = foo.DeepCopyJson();

        foo2.Whatever = "xyz";
        Console.WriteLine(foo);
        Console.WriteLine(foo2);
    }
}
