using Stalker.Utils;

namespace Tests.PhoneNumber;

using Stalker;

public class PhoneCountryCodeTest
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void Creation()
    {
        Assert.DoesNotThrow(() =>
            {
                PhoneCountryCode countryCode1 = new PhoneCountryCode(359);
            }
        );

        Assert.Throws<CountryCodeException>(() =>
            {
                PhoneCountryCode countryCode2 = new PhoneCountryCode(1234);
            });
    }

    [Test]
    public void Conversion()
    {
        PhoneCountryCode countryCode1 = new PhoneCountryCode(359);
        ushort shortCode = countryCode1;

        Assert.That(shortCode, Is.EqualTo(359)); 

        PhoneCountryCode countryCode2 = (PhoneCountryCode)shortCode;
        Assert.That(countryCode2.Get(), Is.EqualTo(359));

        Assert.Throws<CountryCodeConversionException>(() =>
        {
            PhoneCountryCode countryCode3 = (PhoneCountryCode)1234;
        });

        if (countryCode2.TryToIso3166CountryCode(out Iso3166CountryCode? isoCode))
        {
            Assert.NotNull(isoCode);
            Assert.That(isoCode, Is.EqualTo(Iso3166CountryCode.BG));
        }
        else
        {
            Assert.IsNull(isoCode);
        }
        
    }
}