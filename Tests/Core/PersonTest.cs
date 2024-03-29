using Stalker.Core;
using Stalker.Core.ContactInformation;
using Stalker.Core.PersonalInformation;

namespace Tests.Core;

public class PersonTest
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void LivingStatusTest()
    {
        List<Name> names = new List<Name>()
        {
            new Name("John", NameType.GivenName),
            new Name("Johnson", NameType.MiddleName),
            new Name("Doe", NameType.Surname)
        };
        
        Assert.Throws<ImpossibleLivingStatusException>(() =>
        {
            Person person = new Person(names, Gender.Male, new Pronouns("he", "him"), 
                new DateTime(2000,1,1), new DateTime(2023, 11, 4), LivingStatus.Alive, MaritalStatus.Single,
                new ContactInfo());
        });
        
        Person person = new Person(names, Gender.Male, new Pronouns("he", "him"), 
            new DateTime(2000,1,1), null, LivingStatus.Alive, MaritalStatus.Single,
            new ContactInfo());
        
        person.TimeOfDeath = new DateTime(2023, 11, 4);
        
        Assert.That(person.LivingStatus, Is.EqualTo(LivingStatus.Deceased));
    }

    [Test]
    public void TestNames()
    {
        List<Name> names = new List<Name>()
        {
            new Name("John", NameType.GivenName),
            new Name("Johnitty", NameType.GivenName),
            new Name("Johnson", NameType.MiddleName),
            new Name("Doe", NameType.Surname),
            new Name("Doedoe", NameType.Surname)
        };
        
        Person person = new Person(names, Gender.Male, new Pronouns("he", "him"), 
            new DateTime(2000,1,1), null, LivingStatus.Alive, MaritalStatus.Single,
            new ContactInfo());
        
        Assert.That(person.GetFullGivenName(), Is.EqualTo("John-Johnitty"));
        Assert.That(person.GetFullSurname(), Is.EqualTo("Doe-Doedoe"));
    }
}