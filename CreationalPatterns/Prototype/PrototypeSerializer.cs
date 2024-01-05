using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DesignPatternsCourse.Prototype;
public class PrototypeSerializer
{
    //[Serializable] // this is, unfortunately, required
    public class Foo
    {
        public uint Stuff;
        public string Whatever;

        public override string ToString()
        {
            return $"{nameof(Stuff)}: {Stuff}, {nameof(Whatever)}: {Whatever}";
        }
    }
}

public static class ExtensionMethods
{
    //public static T DeepCopy<T>(this T self)
    //{
    //    MemoryStream stream = new MemoryStream();
    //    BinaryFormatter formatter = new BinaryFormatter();
    //    formatter.Serialize(stream, self);
    //    stream.Seek(0, SeekOrigin.Begin);
    //    object copy = formatter.Deserialize(stream);
    //    stream.Close();
    //    return (T)copy;
    //}

    public static T DeepCopyXml<T>(this T self)
    {
        using (var ms = new MemoryStream())
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            s.Serialize(ms, self);
            ms.Position = 0;
            return (T)s.Deserialize(ms);
        }
    }

    public static T DeepCopyJson<T>(this T self)
    {
        string serialized = JsonConvert.SerializeObject(self);

        var newObject = JsonConvert.DeserializeObject<T>(serialized)!;

        return newObject;
    }
}
