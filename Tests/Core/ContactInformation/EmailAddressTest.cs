using Stalker.Core.ContactInformation;

namespace Tests.Core.ContactInformation;

public class EmailAddressTest
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void Validation()
    {
        Assert.That(EmailAddress.IsValid("aBc@ab1C.cOm"));
        Assert.That(EmailAddress.IsValid("aBc.D3f@hi.K0k"));
        Assert.That(EmailAddress.IsValid("aCd.DeF-a13@ga.Lo"));
        Assert.That(EmailAddress.IsValid("aCd.DeF-a14.asd_12l@gol.com"));
        Assert.False(EmailAddress.IsValid("asdf"));
        Assert.False(EmailAddress.IsValid("@asdf"));
        Assert.False(EmailAddress.IsValid("as.ds@asdd"));
    }

    [Test]
    public void GeneralTest()
    {
        Assert.DoesNotThrow(() =>
        {
            EmailAddress email = new EmailAddress("aCd.DeF-a14.asd_12l@gol.com");
        });
        Assert.Throws<EmailAddressException>(() =>
        {
            EmailAddress email = new EmailAddress("asd.");
        });

        EmailAddress email = new EmailAddress("example@example.com");
        Assert.That(email.Provider, Is.EqualTo("example"));

        email.Address = "example@example.example2.com";
        Assert.That(email.Provider, Is.EqualTo("example.example2"));
        
        Assert.Throws<EmailAddressException>(() =>
        {
            email.Address = "invalid@inv";
        });

    }
}