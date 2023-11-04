using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Stalker.Core;

using ContactInformation;
using PersonalInformation;

public class Person
{
    public List<Name> Names { get; set; } = new List<Name>(capacity: 2);
    public Gender Gender { get; set; } = Gender.Other;
    public Pronouns Pronouns { get; set; } = new Pronouns("");

    private LivingStatus _livingStatus = LivingStatus.Alive;
    
    /// <exception cref="ImpossibleLivingStatusException">Thrown when trying to change the person's living status
    /// when they already have a set time of death.</exception>
    public LivingStatus LivingStatus
    {
        get => _livingStatus;
        set
        {
            if (!TimeOfDeath.HasValue)
            {
                _livingStatus = value;
            }
            else
            {
                throw new ImpossibleLivingStatusException(
                    "Trying to change the living status of a person with a known time of death.");
            }
        }
    }

    public MaritalStatus MaritalStatus { get; set; } = MaritalStatus.Single;
    
    public DateTime TimeOfBirth { get; set; } = new DateTime(1, 1, 1);

    private DateTime? _timeOfDeath = null;
    public DateTime? TimeOfDeath
    {
        get => _timeOfDeath;
        set
        {
            if (!_timeOfDeath.HasValue && value.HasValue)
            {
                LivingStatus = LivingStatus.Deceased;
            }
            _timeOfDeath = value;
        }
    }

    public ContactInfo ContactInformation { get; set; } = new ContactInfo();

    public Person()
    {}
    
    public Person(List<Name> names, Gender gender, Pronouns pronouns, DateTime birthday, DateTime? timeOfDeath, 
        LivingStatus livingStatus, MaritalStatus maritalStatus, ContactInfo contactInfo)
    {
        Names = names;
        Gender = gender;
        Pronouns = pronouns;
        TimeOfBirth = birthday;
        TimeOfDeath = timeOfDeath;
        LivingStatus = livingStatus;
        MaritalStatus = maritalStatus;
        ContactInformation = contactInfo;
    }

    public Person(List<Name> names, Gender gender, DateTime birthday, DateTime? timeOfDeath, 
        LivingStatus livingStatus, MaritalStatus maritalStatus, ContactInfo contactInfo)
    {
        Names = names;
        Gender = gender;

        switch (Gender)
        {
            case Gender.Male:
                Pronouns = new Pronouns("he", "him", "him");
                break;
            case Gender.Female:
                Pronouns = new Pronouns("she", "her", "her");
                break;
            case Gender.Other:
                Pronouns = new Pronouns("they", "them", "them");
                break;
        }
        
        TimeOfBirth = birthday;
        TimeOfDeath = timeOfDeath;
        LivingStatus = livingStatus;
        MaritalStatus = maritalStatus;
        ContactInformation = contactInfo;
    }

    public Person(List<Name> names, Gender gender, DateTime birthday) :
        this(names, gender, birthday, null, LivingStatus.Alive, MaritalStatus.Single, new ContactInfo())
    {
    }

    /// <summary>
    /// Get all the given names of the person.
    /// </summary>
    public List<Name> GetGivenNames()
    {
        return Names.FindAll(name => name.Type == NameType.GivenName);
    }

    /// <summary>
    /// Get all the surnames of the person.
    /// </summary>
    public List<Name> GetSurnames()
    {
        return Names.FindAll(name => name.Type == NameType.Surname);
    }

    /// <summary>
    /// Get the full given name of the person by concatenating their given names and separating them with a dash ('-').
    /// </summary>
    public string GetFullGivenName()
    {
        List<Name> givenNames = GetGivenNames();
        string fullGivenName = "";
        
        foreach(Name name in givenNames)
        {
            fullGivenName += name.Get() + '-';
        }

        return fullGivenName.TrimEnd('-');
    }

    /// <summary>
    /// Get the full surname of the person by concatenating their various surnames and separating them with a dash ('-').
    /// </summary>
    public string GetFullSurname()
    {
        List<Name> givenNames = GetSurnames();
        string fullGivenName = "";
        
        foreach(Name name in givenNames)
        {
            fullGivenName += name.Get() + '-';
        }

        return fullGivenName.TrimEnd('-');
    }
}

public enum LivingStatus
{
    Alive,
    Comatose,
    Deceased,
    Unknown
}

public class ImpossibleLivingStatusException : Exception
{
    public ImpossibleLivingStatusException() : base("This is not a possible living status.")
    {}
    
    public ImpossibleLivingStatusException(string message) : base(message)
    {}

    public ImpossibleLivingStatusException(string message, Exception inner) : base(message, inner)
    {}
}