using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Stalker.Utils;

public static class Serializer
{
    /// <summary>
    /// Serialize an object to an XML file.
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

    /// <summary>
    /// Deserialises an XML file into the an object of the specified type.
    /// </summary>
    /// <param name="filepath">The path of the XML file to deserialise.</param>
    /// <typeparam name="T">The type of object to be created.</typeparam>
    /// <returns>An object deserialised from the XML file.</returns>
    public static T DeserializeXmlFile<T>(string filepath)
    {
        var xmlSerializer = new XmlSerializer(typeof(T));
        using var reader = new StreamReader(filepath);
        return (T)xmlSerializer.Deserialize(reader) ?? throw new SerializationException();
    }
}