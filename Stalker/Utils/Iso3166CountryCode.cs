namespace Stalker.Utils;

using System;

public static class Iso3166CountryCodeExtensions
{
    public static string ToString(this Iso3166CountryCode code)
    {
        return "";
    }
}

public class CountryCodeException : Exception
{
    public CountryCodeException() : base("Something went wrong with the country code.")
    {}
    
    public CountryCodeException(string message) : base(message)
    {}

    public CountryCodeException(string message, Exception inner) : base(message, inner)
    {}
}

public enum Iso3166CountryCode
{
    AF = 004, // Afghanistan
    AX = 248, // Åland Islands
    AL = 008, // Albania
    DZ = 012, // Algeria
    AS = 016, // American Samoa
    AD = 020, // Andorra
    AO = 024, // Angola
    AI = 660, // Anguilla
    AQ = 010, // Antarctica
    AG = 028, // Antigua and Barbuda
    AR = 032, // Argentina
    AM = 051, // Armenia
    AW = 533, // Aruba
    AU = 036, // Australia
    AT = 040, // Austria
    AZ = 031, // Azerbaijan
    BS = 044, // The Bahamas
    BH = 048, // Bahrain
    BD = 050, // Bangladesh
    BB = 052, // Barbados
    BY = 112, // Belarus
    BE = 056, // Belgium
    BZ = 084, // Belize
    BJ = 204, // Benin
    BM = 060, // Bermuda
    BT = 064, // Bhutan
    BO = 068, // Bolivia
    BQ = 535, // Bonaire, Sint Eustaitius, Saba
    BA = 070, // Bosnia and Herzegovina
    BW = 072, // Botswana
    BV = 074, // Bouvet Island
    BR = 076, // Brazil
    IO = 086, // The British Indian Ocean Territory
    BN = 096, // Brunei Derussalam
    BG = 100, // Bulgaria
    BF = 854, // Burkina Faso
    BI = 108, // Burundi
    CV = 132, // Cabo Verde
    KH = 116, // Cambodia
    CM = 120, // Cameroon
    CA = 124, // Canada
    KY = 136, // The Cayman Islands
    CF = 140, // The Central African Republic
    TD = 148, // Chad
    CL = 152, // Chile
    CN = 156, // China
    CX = 162, // Christmas Island
    CC = 166, // Cocos Islands
    CO = 170, // Colombia
    KM = 174, // The Comoros
    CD = 180, // The Democratic Republic of Congo
    CG = 178, // The Republic of Congo
    CK = 184, // The Cook Islands
    CR = 188, // Costa Rica
    CI = 384, // Côte d'Ivoire
    HR = 191, // Croatia
    CU = 192, // Cuba
    CW = 531, // Curaçao
    CY = 196, // Cyprus
    CZ = 203, // Czechia
    DK = 208, // Denmark
    DJ = 262, // Djibouti
    DM = 212, // Dominica
    DO = 214, // The Dominican Republic
    EC = 218, // Ecuador
    EG = 818, // Egypt
    SV = 222, // El Salvador
    GQ = 226, // Equatorial Guinea
    ER = 232, // Eritrea,
    EE = 233, // Estonia
    SZ = 748, // Eswatini
    ET = 231, // Ethiopia
    FK = 238, // The Falkland Islands
    FO = 234, // The Faroe Islands
    FJ = 242, // Fiji
    FI = 246, // Finland
    FR = 250, // France
    GF = 254, // French Guiana
    PF = 258, // French Polynesia
    TF = 260, // The French Southern Terriroties
    GA = 266, // Gabon
    GM = 270, // Gambia
    GE = 268, // Georgia
    DE = 276, // Germany
    GH = 288, // Ghana
    GI = 292, // Gibraltar
    GR = 300, // Greece
    GL = 304, // Greenland
    GD = 308, // Grenada
    GP = 312, // Guadeloupe
    GU = 316, // Guam
    GT = 320, // Guatemala
    GG = 831, // Guernsey
    GN = 324, // Guinea
    GW = 624, // Guinea-Bissau
    GY = 328, // Guyana
    HT = 332, // Haiti
    HM = 334, // The Territory of Heard Island and McDonald Islands
    VA = 336, // The Holy See
    HN = 340, // Honduras
    HK = 344, // Hong Kong
    HU = 348, // Hungary
    IS = 352, // Iceland
    IN = 356, // India
    ID = 360, // Indonesia
    IR = 364, // Iran
    IQ = 368, // Iraq
    IE = 372, // Ireland
    IM = 833, // Isle of man
    IL = 376, // Israel
    IT = 380, // Italy
    JM = 388, // Jamaica
    JP = 392, // Japan
    JE = 832, // Jersey
    JO = 400, // Jordan
    KZ = 398, // Kazakhstan
    KE = 404, // Kenya
    KI = 296, // Kiribati
    KP = 408, // North Korea
    KR = 410, // South Korea
    KW = 414, // Kuwait
    KG = 417, // Kyrgyzstan
    LA = 418, // The Lao People's Democratic Republic
    LV = 428, // Latvia
    LB = 422, // Lebanon
    LS = 426, // Lesotho
    LR = 430, // Liberia
    LY = 434, // Libya
    LI = 438, // Liechtenstein
    LT = 440, // Lithuania
    LU = 442, // Luxembourg
    MO = 446, // Macao
    MK = 807, // North Macedonia
    MG = 450, // Madagascar
    MW = 454, // Malawi
    MY = 458, // Malaysia
    MV = 462, // Maldives
    ML = 466, // Mali
    MT = 470, // Malta
    MH = 584, // The Marshall Islands
    MQ = 474, // Martinique
    MR = 478, // Mauritania
    MU = 480, // Mauritius
    YT = 175, // Mayotte
    MX = 484, // Mexico
    FM = 583, // Micronesia
    MD = 498, // Moldova
    MC = 492, // Monaco
    MN = 496, // Mongolia
    ME = 499, // Montenegro
    MS = 500, // Montserrat
    MA = 504, // Morocco
    MZ = 508, // Mozambique
    MM = 104, // Myanmar
    NA = 516, // Namibia
    NR = 520, // Nauru
    NP = 524, // Nepal
    NL = 528, // The Netherlands
    NC = 540, // New Caledonia
    NZ = 554, // New Zealand
    NI = 558, // Nicaragua
    NE = 562, // Niger
    NG = 556, // Nigeria
    NU = 570, // Niue
    NF = 574, // Norfolk Island
    MP = 580, // The Commonwealth of the Northern Mariana Islands
    NO = 578, // Norway
    OM = 512, // Oman
    PK = 586, // Pakistan
    PW = 585, // Palau
    PS = 275, // Palestine
    PA = 591, // Panama
    PG = 598, // Papua New Guinea
    PY = 600, // Paraguay,
    PE = 604, // Peru
    PH = 608, // The Philippines
    PN = 612, // Pitcairn
    PL = 616, // Poland,
    PT = 620, // Portugal
    PR = 630, // Puerto Rico
    QA = 634, // Qatar
    RE = 638, // Réunion
    RO = 642, // Romania
    RU = 643, // Russia
    RW = 646, // Rwanda
    BL = 652, // Saint Barthélemy
    SH = 654, // Saint Helena, Ascension and Tristan da Cunha
    KN = 659, // Saint Kitts and Nevis
    LC = 662, // Saint Lucia
    MF = 663, // Saint Martin
    PM = 666, // Saint Pierre and Miquelon
    VC = 670, // Saint Vincent and the Grenadines
    WS = 882, // Samoa
    SM = 647, // San Marino
    ST = 678, // The Democratic Republic of São Tomé and Príncipe
    SA = 682, // Saudi Arabia
    SN = 686, // Senegal
    RS = 688, // Serbia
    SC = 690, // Seychelles
    SL = 694, // Sierra Leone
    SG = 702, // Singapore
    SX = 534, // Sint Maarten
    SI = 705, // Slovenia
    SK = 703, // Slovakia
    SB = 090, // Solomon Islands
    SO = 706, // Somalia
    ZA = 710, // South Africa
    GS = 239, // South Georgia and the South Sandwich Islands
    SS = 728, // South Sudan
    ES = 724, // Spain
    LK = 144, // Sri Lanka
    SD = 729, // Sudan
    SR = 740, // Suriname
    SJ = 744, // Svalbard and Jan Mayen
    SE = 752, // Sweden
    CH = 756, // Switzerland
    SY = 760, // The Syrian Arab Republic
    TW = 158, // Taiwan
    TJ = 762, // Tajikistan
    TZ = 834, // Tanzania
    TH = 764, // Thailand
    TL = 626, // Timor-Leste
    TG = 768, // Togo
    TK = 772, // Tokelau
    TO = 776, // Tonga
    TT = 780, // Trinidad and Tobago
    TN = 788, // Tunisia
    TR = 792, // Türkiye
    TM = 795, // Turkmenistan
    TC = 796, // The Turks and Caicos Islands
    TV = 798, // Tuvalu
    UG = 800, // Uganda
    UA = 804, // Ukraine
    AE = 784, // The United Arab Emirates
    GB = 826, // The United Kingdom of Great Britain and Northern Ireland
    UM = 581, // The United States Minor Outlying Islands
    US = 840, // The United States of America
    UY = 858, // Uruguay
    UZ = 860, // Uzbekistan
    VU = 548, // Vanuatu
    VE = 862, // Venezuela
    VN = 704, // Viet Name
    VG = 092, // The Virgin Islands (UK)
    VI = 850, // The Virgin Islands of the United States
    WF = 876, // Wallis and Futuna
    EH = 732, // Western Sahara
    YE = 887, // Yemen
    ZM = 894, // Zambia
    ZW = 716, // Zimbabwe
}