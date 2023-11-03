using System;
using LibPhoneNumbers = PhoneNumbers;

namespace Stalker.Core.ContactInformation;

public struct PhoneNumber
{
    private static LibPhoneNumbers.PhoneNumberUtil _parser;
    
    private LibPhoneNumbers.PhoneNumber _number;

    static PhoneNumber()
    {
        _parser = LibPhoneNumbers.PhoneNumberUtil.GetInstance();
    }

    public static bool IsValid(string number)
    {
        LibPhoneNumbers.PhoneNumber phoneNumber = _parser.Parse("number", "");
        return _parser.IsValidNumber(phoneNumber);
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
        
        _number = _parser.Parse(number, "");
        
        if (!_parser.IsValidNumber(_number))
        {
            throw new InvalidPhoneNumberException("The phone number specified is invalid.");
        }
    }
    
    /// <returns>The phone number's country code.</returns>
    public PhoneCountryCode GetCountryCode() => new PhoneCountryCode((ushort)_number.CountryCode);
    
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