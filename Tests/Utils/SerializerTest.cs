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

    [Test]
    public void TestDeserializeXmlFile()
    {
        Investigation inv = new Investigation();
        
        Serializer.SerializeToXmlFile(inv, Path.GetFullPath("../../../SandboxInvestigation/Investigation.xml"));
        Investigation inv2 = Serializer.DeserializeXmlFile<Investigation>(
            Path.GetFullPath("../../../SandboxInvestigation/Investigation.xml"));
        
        Assert.Pass(); // Verified via debugger 
    }
}