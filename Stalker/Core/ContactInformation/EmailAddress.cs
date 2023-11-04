using System;
using System.Text.RegularExpressions;

namespace Stalker.Core.ContactInformation;

public struct EmailAddress
{
    private string _address = "";
    /// <summary>
    /// The actual string representation of the email address.
    /// </summary>
    /// <exception cref="EmailAddressException">Thrown when trying to set the address to a string
    /// which does not match the pattern of a valid email address.</exception>
    public string Address
    {
        set
        {
            if (!IsValid(value))
            {
                throw new EmailAddressException("Not a valid email address.");
            }
            
            _address = value;
        }

        get => _address;
    }

    /// <summary>
    /// The email provider associated with the email address.
    /// </summary>
    public string Provider
    {
        get
        {
            int indexOfAtCharacter = _address.LastIndexOf('@');
            return _address.Substring(indexOfAtCharacter + 1, _address.LastIndexOf('.') - indexOfAtCharacter - 1);
        }
    }

    /// <summary>
    /// The type of the email address.
    /// </summary>
    public EmailAddressType Type { get; set; } = EmailAddressType.Personal;
    
    private static readonly Regex EmailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", 
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    /// <summary>
    /// Creates a new <c>EmailAddress</c> from the specified string.
    /// </summary>
    /// <param name="address">The string to construct the email address from.</param>
    public EmailAddress(string address)
    {
        Address = address;
    }

    /// <summary>
    /// Creates a new <c>EmailAddress</c> from the specified string.
    /// </summary>
    /// <param name="address">The string to construct the email address from.</param>
    /// <param name="type">The type of the email address.</param>
    public EmailAddress(string address, EmailAddressType type)
    {
        Address = address;
        Type = type;
    }

    /// <summary>
    /// Checks if the specified string matches the pattern of a valid email address.
    /// </summary>
    /// <returns></returns>
    public static bool IsValid(string address)
    {
        return EmailRegex.IsMatch(address);
    }
    
}

public enum EmailAddressType
{
    Personal,
    Education,
    Enterprise,
    Other
}

public class EmailAddressException : Exception
{
    public EmailAddressException() : base("Not a valid email address.")
    {}
    
    public EmailAddressException(string message) : base(message)
    {}

    public EmailAddressException(string message, Exception inner) : base(message, inner)
    {}
}