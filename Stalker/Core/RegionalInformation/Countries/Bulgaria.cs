using Stalker.Core.ContactInformation;

namespace Stalker.Core.RegionalInformation.Countries;

/// <summary>
/// A (wanna-be static) class which represents country information about The Republic of Bulgaria.
/// </summary>
public sealed class Bulgaria : ICountry
{
    public const string CommonName = "Bulgaria";
    public const string OfficialName = "The Republic of Bulgaria";
    public const string FlagImagePath = "";
    public const Iso3166CountryCode CountryCode = Iso3166CountryCode.BG;
    public static readonly PhoneCountryCode PhoneCountryCode = new PhoneCountryCode(359);

    private Bulgaria()
    {
    }
}