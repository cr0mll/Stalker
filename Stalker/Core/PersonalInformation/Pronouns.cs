namespace Stalker.Core.PersonalInformation;

public struct Pronouns
{
    public string NominativePronoun { get; set; }
    public string AccusativePronoun { get; set; }
    public string DativePronoun { get; set; }

    public Pronouns()
    {
        NominativePronoun = "";
        AccusativePronoun = "";
        DativePronoun = "";
    }
    
    public Pronouns(string pronoun)
    {
        NominativePronoun = pronoun;
        AccusativePronoun = pronoun;
        DativePronoun = AccusativePronoun;
    }
    
    public Pronouns(string nominativePronoun, string accusativePronoun)
    {
        NominativePronoun = nominativePronoun;
        AccusativePronoun = accusativePronoun;
        DativePronoun = AccusativePronoun;
    }
    
    public Pronouns(string nominativePronoun, string accusativePronoun, string dativePronoun)
    {
        NominativePronoun = nominativePronoun;
        AccusativePronoun = accusativePronoun;
        DativePronoun = dativePronoun;
    }
}