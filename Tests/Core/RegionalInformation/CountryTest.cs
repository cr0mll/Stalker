using Stalker.Core.ContactInformation;
using Stalker.Core.RegionalInformation;
using Stalker.Core.RegionalInformation.Countries;

namespace Tests.Core.RegionalInformation;

public class CountryTest
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void TestCountry()
    {
        Assert.That(Bulgaria.CountryCode, Is.EqualTo(Iso3166CountryCode.BG));
        Assert.That(Bulgaria.CommonName, Is.EqualTo("Bulgaria"));
        Assert.That(Bulgaria.OfficialName, Is.EqualTo("The Republic of Bulgaria"));
        Assert.That(Bulgaria.FlagImagePath, Is.EqualTo(""));
        Assert.That(Bulgaria.PhoneCountryCode, Is.EqualTo(new PhoneCountryCode(359)));
    }
}