namespace Stalker.Core.PersonalInformation;

public struct Name
{
    private string _name = "";
    public NameType Type { get; set; } = NameType.GivenName;

    public Name(string name, NameType type)
    {
        _name = name;
        Type = type;
    }
    
    public void Set(string name)
    {
        _name = name;
    }

    public string Get()
    {
        return _name;
    }
}

public enum NameType
{
    GivenName,
    MiddleName,
    Surname
}