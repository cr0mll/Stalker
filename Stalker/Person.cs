using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.JavaScript;

namespace Stalker;

public class Person
{
    private List<string> Names;
    public Gender Gender;
    public Pronouns Pronouns;
    public DateOnly Birthday;

    public Person(List<string> names, Gender gender, Pronouns pronouns, DateOnly birthday)
    {
        Names = names;
        Gender = gender;
        Pronouns = pronouns;
        Birthday = birthday;
    }
    
    public string GetFirstName()
    {
        return Names.First();
    }

    public string GetLastName()
    {
        return Names.Last();
    }

    public void SetName(int index, string name)
    {
        Names[index] = name;
    }

    public void AddName(string name)
    {
        this.Names.Add(name);
    }

    public void RemoveName(int index)
    {
        this.Names.RemoveAt(index);
    }
}

public enum Gender
{
    Male,
    Female,
    Other
}

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