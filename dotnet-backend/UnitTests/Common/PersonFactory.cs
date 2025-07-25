using Bogus;
using Domain.Entities;
using Person = Domain.Entities.Person;

namespace UnitTests.Common;

public static class PersonFactory
{
    public static List<Person> CreateTestPeople(int count, List<Country> countries, int? seed = null)
    {
        if (countries.Count <= 0)
            throw new ArgumentException("Cannot create more people than available countries");
        
        var faker = new Faker<Person>();
        
        if (seed.HasValue)
            faker.UseSeed(seed.Value);
            
        faker.RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.DOB, f => f.Date.Past(30, DateTime.Now.AddYears(-18)))
            .RuleFor(p => p.Address, f => f.Address.StreetAddress())
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(p => p.ImagePath, f => f.Internet.Avatar())
            .FinishWith((f, p) =>
            {
                var country = f.PickRandom(countries);
                p.CountryId = country.Id;
            });

        return faker.Generate(count);
    }
}