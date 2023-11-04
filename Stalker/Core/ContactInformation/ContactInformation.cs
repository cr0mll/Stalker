using System.Collections.Generic;
using PhoneNumbers;

namespace Stalker.Core.ContactInformation;

public class ContactInformation
{
    public List<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>(capacity: 1);
    public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>(capacity: 1);

    public ContactInformation()
    {
    }
    
    public ContactInformation(List<EmailAddress> emailAddresses, List<PhoneNumber> phoneNumbers)
    {
        EmailAddresses = emailAddresses;
        PhoneNumbers = phoneNumbers;
    }
    
    /// <param name="type">The type of email address to look for.</param>
    /// <returns>Returns only the email addresses of the specified type. </returns>
    public List<EmailAddress> GetEmailAddressesOfType(EmailAddressType type)
    {
        return EmailAddresses.FindAll(email => email.Type == type);
    }

    /// <param name="type">The type of phone number to look for.</param>
    /// <returns>Returns only the phone numbers of the specified type. </returns>
    public List<PhoneNumber> GetPhoneNumbersOfType(PhoneNumberType type)
    {
        return PhoneNumbers.FindAll(number => number.Type == type);
    }
}