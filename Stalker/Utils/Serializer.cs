using System.IO;
using System.Xml.Serialization;

namespace Stalker.Utils;

public static class Serializer
{
    /// <summary>
    /// A method to serialize an object to an XML file.
    /// </summary>
    /// <param name="objectToSerialize">The object to serialize.</param>
    /// <param name="filepath">The filepath where the XML file should be saved.</param>
    /// <typeparam name="T">The type of the object to be serialized.</typeparam>
    public static void SerializeToXmlFile<T>(T objectToSerialize, string filepath)
    {
        var xmlSerializer = new XmlSerializer(typeof(T));
        using var writer = new StreamWriter(filepath);
        xmlSerializer.Serialize(writer, objectToSerialize);
    }
}