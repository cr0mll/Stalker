using System.Reflection;
using Stalker.Core;
using Stalker.Utils;

namespace Tests.Utils;

public class SerializerTest
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void TestSerializeToXmlFile()
    {
        Investigation inv = new Investigation();
        
        Serializer.SerializeToXmlFile(inv, Path.GetFullPath("../../../SandboxInvestigation/Investigation.xml"));
        Assert.Pass();
    }
}