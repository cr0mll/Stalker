using System;
using LibPhoneNumbers = PhoneNumbers;

namespace Stalker.Core.ContactInformation;

public readonly struct PhoneNumber
{
    private static readonly LibPhoneNumbers.PhoneNumberUtil Parser;
    
    private readonly LibPhoneNumbers.PhoneNumber _number;

    public PhoneNumberType Type { get; } = PhoneNumberType.Personal;
    
    public PhoneCountryCode CountryCode { get; }
    
    static PhoneNumber()
    {
        Parser = LibPhoneNumbers.PhoneNumberUtil.GetInstance();
    }

    public static bool IsValid(string number)
    {
        LibPhoneNumbers.PhoneNumber phoneNumber = Parser.Parse("number", "");
        return Parser.IsValidNumber(phoneNumber);
    }
    
    /// <summary>
    /// Creates a new <c>PhoneNumber</c> from the specified string.
    /// </summary>
    /// <param name="number">The string must represent a valid phone number in international format (starting with a '+').</param>
    /// <exception cref="InvalidPhoneNumberException">Thrown when the phone number is not in international format or is generally an invalid number.</exception>
    public PhoneNumber(string number)
    {
        if (!number.StartsWith('+'))
        {
            throw new InvalidPhoneNumberException("The phone number must be specified in international format.");
        }
        
        _number = Parser.Parse(number, "");
        
        if (!Parser.IsValidNumber(_number))
        {
            throw new InvalidPhoneNumberException("The phone number specified is invalid.");
        }
        
        CountryCode = new PhoneCountryCode((ushort)_number.CountryCode);
    }

    /// <summary>
    /// Creates a new <c>PhoneNumber</c> of the provided type from the specified string.
    /// </summary>
    /// <param name="number">The string must represent a valid phone number in international format (starting with a '+').</param>
    /// <param name="type">The type of the phone number (personal, home, work, etc.)</param>
    /// <exception cref="InvalidPhoneNumberException">Thrown when the phone number is not in international format or is generally an invalid number.</exception>
    public PhoneNumber(string number, PhoneNumberType type) : this(number)
    {
        Type = type;
    }
    
}

public enum PhoneNumberType
{
    Personal,
    Home,
    Work,
    Other
    
}

public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException() : base("Not a valid phone number.")
    {}
    
    public InvalidPhoneNumberException(string message) : base(message)
    {}

    public InvalidPhoneNumberException(string message, Exception inner) : base(message, inner)
    {}
}