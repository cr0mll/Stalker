namespace Tests.Core.ContactInformation;

using Stalker.Core.ContactInformation;

public class ContactInformationTest
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void GeneralTest()
    {
        ContactInformation info = new ContactInformation();
        info.EmailAddresses.Add(new EmailAddress("abc.abc@gef.com", EmailAddressType.Personal));
        info.EmailAddresses.Add(new EmailAddress("xyz.cde@gef.com", EmailAddressType.Personal));
        info.EmailAddresses.Add(new EmailAddress("alfa.beta@gef.com", EmailAddressType.Enterprise));

        Assert.That(info.GetEmailAddressesOfType(EmailAddressType.Personal).Count, Is.EqualTo(2));
        
        info.PhoneNumbers.Add(new PhoneNumber("+359881111111", PhoneNumberType.Personal));
        info.PhoneNumbers.Add(new PhoneNumber("+359882222222", PhoneNumberType.Work));
        info.PhoneNumbers.Add(new PhoneNumber("+359883333333", PhoneNumberType.Work));
        
        Assert.That(info.GetPhoneNumbersOfType(PhoneNumberType.Work).Count, Is.EqualTo(2));

    }
}