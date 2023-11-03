using System.Dynamic;
using Stalker.Core.ContactInformation;

namespace Stalker.Core.RegionalInformation;

public interface ICountry
{
    public const string CommonName = "";
    public const string OfficialName = "";
    public const string FlagImagePath = "";

    public const Iso3166CountryCode CountryCode = Iso3166CountryCode.None;
    public static readonly PhoneCountryCode PhoneCountryCode = new PhoneCountryCode(0);
    
}