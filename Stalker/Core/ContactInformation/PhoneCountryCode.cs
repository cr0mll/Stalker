using System.Collections.Generic;
using System;
using Stalker.Core.RegionalInformation;

namespace Stalker.Core.ContactInformation;

public struct PhoneCountryCode
{
    private static readonly Dictionary<ushort, List<Iso3166CountryCode>> CountryCodes = new Dictionary<ushort, List<Iso3166CountryCode>>(286)
    {
        { 1, new List<Iso3166CountryCode>(25)
                    {
                        Iso3166CountryCode.US,
                        Iso3166CountryCode.AG,
                        Iso3166CountryCode.AI,
                        Iso3166CountryCode.AS,
                        Iso3166CountryCode.BB,
                        Iso3166CountryCode.BM,
                        Iso3166CountryCode.BS,
                        Iso3166CountryCode.CA,
                        Iso3166CountryCode.DM,
                        Iso3166CountryCode.DO,
                        Iso3166CountryCode.GD,
                        Iso3166CountryCode.GU,
                        Iso3166CountryCode.JM,
                        Iso3166CountryCode.KN,
                        Iso3166CountryCode.KY,
                        Iso3166CountryCode.LC,
                        Iso3166CountryCode.MP,
                        Iso3166CountryCode.MS,
                        Iso3166CountryCode.PR,
                        Iso3166CountryCode.SX,
                        Iso3166CountryCode.TC,
                        Iso3166CountryCode.TT,
                        Iso3166CountryCode.VC,
                        Iso3166CountryCode.VG,
                        Iso3166CountryCode.VI
                    }},
                { 7, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.RU,
                        Iso3166CountryCode.KZ
                    }},
                { 20, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.EG }},
                { 27, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ZA }},
                { 30, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GR }},
                { 31, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NL }},
                { 32, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BE }},
                { 33, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.FR }},
                { 34, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ES }},
                { 36, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.HU }},
                { 39, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.IT,
                        Iso3166CountryCode.VA
                    }},
                { 40, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.RO }},
                { 41, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CH }},
                { 43, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AT }},
                { 44, new List<Iso3166CountryCode>(4)
                    {
                        Iso3166CountryCode.GB,
                        Iso3166CountryCode.GG,
                        Iso3166CountryCode.IM,
                        Iso3166CountryCode.JE
                    }},
                { 45, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.DK }},
                { 46, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SE }},
                { 47, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.NO,
                        Iso3166CountryCode.SJ
                    }},
                { 48, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PL }},
                { 49, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.DE }},
                { 51, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PE }},
                { 52, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MX }},
                { 53, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CU }},
                { 54, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AR }},
                { 55, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BR }},
                { 56, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CL }},
                { 57, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CO }},
                { 58, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.VE }},
                { 60, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MY }},
                { 61, new List<Iso3166CountryCode>(3)
                    {
                        Iso3166CountryCode.AU,
                        Iso3166CountryCode.CC,
                        Iso3166CountryCode.CX
                    }},
                { 62, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ID }},
                { 63, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PH }},
                { 64, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NZ }},
                { 65, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SG }},
                { 66, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TH }},
                { 81, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.JP }},
                { 82, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KR }},
                { 84, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.VN }},
                { 86, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CN }},
                { 90, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TR }},
                { 91, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IN }},
                { 92, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PK }},
                { 93, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AF }},
                { 94, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LK }},
                { 95, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MM }},
                { 98, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IR }},
                { 211, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SS }},
                { 212, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.MA,
                        Iso3166CountryCode.EH
                    }},
                { 213, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.DZ }},
                { 216, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TN }},
                { 218, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LY }},
                { 220, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GM }},
                { 221, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SN }},
                { 222, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MR }},
                { 223, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ML }},
                { 224, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GN }},
                { 225, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CI }},
                { 226, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BF }},
                { 227, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NE }},
                { 228, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TG }},
                { 229, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BJ }},
                { 230, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MU }},
                { 231, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LR }},
                { 232, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SL }},
                { 233, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GH }},
                { 234, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NG }},
                { 235, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TD }},
                { 236, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CF }},
                { 237, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CM }},
                { 238, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CV }},
                { 239, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ST }},
                { 240, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GQ }},
                { 241, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GA }},
                { 242, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CG }},
                { 243, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CD }},
                { 244, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AO }},
                { 245, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GW }},
                { 246, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IO }},
                { 247, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SH }},
                { 248, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SC }},
                { 249, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SD }},
                { 250, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.RW }},
                { 251, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ET }},
                { 252, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SO }},
                { 253, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.DJ }},
                { 254, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KE }},
                { 255, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TZ }},
                { 256, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.UG }},
                { 257, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BI }},
                { 258, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MZ }},
                { 260, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ZM }},
                { 261, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MG }},
                { 262, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.RE,
                        Iso3166CountryCode.YT
                    }},
                { 263, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ZW }},
                { 264, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NA }},
                { 265, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MW }},
                { 266, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LS }},
                { 267, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BW }},
                { 268, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SZ }},
                { 269, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KM }},
                { 290, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SH }},
                { 291, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ER }},
                { 297, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AW }},
                { 298, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.FO }},
                { 299, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GL }},
                { 350, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GI }},
                { 351, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PT }},
                { 352, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LU }},
                { 353, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IE }},
                { 354, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IS }},
                { 355, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AL }},
                { 356, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MT }},
                { 357, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CY }},
                { 358, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.FI,
                        Iso3166CountryCode.AX
                    }},
                { 359, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BG }},
                { 370, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LT }},
                { 371, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LV }},
                { 372, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.EE }},
                { 373, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MD }},
                { 374, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AM }},
                { 375, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BY }},
                { 376, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AD }},
                { 377, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MC }},
                { 378, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SM }},
                { 380, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.UA }},
                { 381, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.RS }},
                { 382, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.ME }},
                { 383, new List<Iso3166CountryCode>(1) {  }},
                { 385, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.HR }},
                { 386, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SI }},
                { 387, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BA }},
                { 389, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MK }},
                { 420, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CZ }},
                { 421, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SK }},
                { 423, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LI }},
                { 500, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.FK }},
                { 501, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BZ }},
                { 502, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GT }},
                { 503, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SV }},
                { 504, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.HN }},
                { 505, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NI }},
                { 506, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CR }},
                { 507, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PA }},
                { 508, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PM }},
                { 509, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.HT }},
                { 590, new List<Iso3166CountryCode>(3)
                    {
                        Iso3166CountryCode.GP,
                        Iso3166CountryCode.BL,
                        Iso3166CountryCode.MF
                    }},
                { 591, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BO }},
                { 592, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GY }},
                { 593, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.EC }},
                { 594, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GF }},
                { 595, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PY }},
                { 596, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MQ }},
                { 597, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SR }},
                { 598, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.UY }},
                { 599, new List<Iso3166CountryCode>(2)
                    {
                        Iso3166CountryCode.CW,
                        Iso3166CountryCode.BQ
                    }},
                { 670, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TL }},
                { 672, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NF }},
                { 673, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BN }},
                { 674, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NR }},
                { 675, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PG }},
                { 676, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TO }},
                { 677, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SB }},
                { 678, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.VU }},
                { 679, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.FJ }},
                { 680, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PW }},
                { 681, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.WF }},
                { 682, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.CK }},
                { 683, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NU }},
                { 685, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.WS }},
                { 686, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KI }},
                { 687, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NC }},
                { 688, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TV }},
                { 689, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PF }},
                { 690, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TK }},
                { 691, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.FM }},
                { 692, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MH }},
                { 800, new List<Iso3166CountryCode>(1) {  }},
                { 808, new List<Iso3166CountryCode>(1) {  }},
                { 850, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KP }},
                { 852, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.HK }},
                { 853, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MO }},
                { 855, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KH }},
                { 856, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LA }},
                { 870, new List<Iso3166CountryCode>(1) {  }},
                { 878, new List<Iso3166CountryCode>(1) {  }},
                { 880, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BD }},
                { 881, new List<Iso3166CountryCode>(1) {  }},
                { 882, new List<Iso3166CountryCode>(1) {  }},
                { 883, new List<Iso3166CountryCode>(1) {  }},
                { 886, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TW }},
                { 888, new List<Iso3166CountryCode>(1) {  }},
                { 960, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MV }},
                { 961, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.LB }},
                { 962, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.JO }},
                { 963, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SY }},
                { 964, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IQ }},
                { 965, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KW }},
                { 966, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.SA }},
                { 967, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.YE }},
                { 968, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.OM }},
                { 970, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.PS }},
                { 971, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AE }},
                { 972, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.IL }},
                { 973, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BH }},
                { 974, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.QA }},
                { 975, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.BT }},
                { 976, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.MN }},
                { 977, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.NP }},
                { 979, new List<Iso3166CountryCode>(1) {  }},
                { 992, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TJ }},
                { 993, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.TM }},
                { 994, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.AZ }},
                { 995, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.GE }},
                { 996, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.KG }},
                { 998, new List<Iso3166CountryCode>(1) { Iso3166CountryCode.UZ }}
    };

    private ushort _code = 0;

    /// <summary>
    /// Creates a new <c>PhoneCountryCode</c> from the specified value.
    /// </summary>
    /// <param name="code">The integer value of the country code.</param>
    /// <exception cref="CountryCodeException">Thrown when the provided number is not a valid country code.</exception>
    public PhoneCountryCode(ushort code)
    {
        if (!IsValid(code))
        {
            throw new CountryCodeException();
        }

        _code = code;
    }
    
    /// <returns>The integer value of the country code.</returns>
    public ushort Get() => _code;

    /// <summary>
    /// Sets the integer value of the phone number country code to the specified value.
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    /// <exception cref="CountryCodeException">Thrown when the specified value does not represent a valid phone number country code</exception>
    public void Set(ushort code)
    {
        if (!IsValid(code))
        {
            throw new CountryCodeException();
        }

        _code = code;
    }

    /// <summary>
    /// Checks if the given integer stands for a valid phone number country code.
    /// </summary>
    /// <param name="code">The integer value to check.</param>
    public static bool IsValid(ushort code)
    {
        return CountryCodes.ContainsKey(code);
    }

    /// <summary>
    /// Checks if the country code represents a country under NANP.
    /// </summary>
    public bool IsNANP()
    {
        return _code == 1;
    }
    
    public static implicit operator ushort(PhoneCountryCode code) => code.Get();
    public static explicit operator PhoneCountryCode(ushort code)
    {
        if (!IsValid(code))
        {
            throw new CountryCodeConversionException("The specified value does not represent a phone number country code.");
        }

        return new PhoneCountryCode(code);
    }
    
    /// <summary>
    /// Attempts to convert the code to an ISO 3166 country code.
    /// Some phone number codes do not map to a single ISO 3166 code (such as those belonging to countries under NANP)
    /// and others do not even represent geographical areas, hence this conversion is not always possible.
    /// </summary>
    /// <param name="code">The resulting ISO 3166 country code (if such exists).</param>
    /// <returns>
    /// True if the conversion was successful, i.e. the phone number can be unambiguously mapped to a single ISO 3166 country code.
    /// False, otherwise.
    /// </returns>
    public bool TryToIso3166CountryCode(out Iso3166CountryCode? code)
    {
        if (CountryCodes[_code].Count != 1)
        {
            // The code cannot be uniquely assigned to an ISO 3166 country code
            code = null;
            return false;
        }

        code = CountryCodes[_code][0]; // The unique ISO 3166 country code corresponding to this phone number country code (what a mouthful)
        return true;
    }
}

public class CountryCodeConversionException : CountryCodeException
{
    public CountryCodeConversionException() : base("Country code conversion failed.")
    {}
    
    public CountryCodeConversionException(string message) : base(message)
    {}

    public CountryCodeConversionException(string message, Exception inner) : base(message, inner)
    {}
}