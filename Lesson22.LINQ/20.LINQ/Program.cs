using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().DistinctBy(p => p.Name);

foreach (Person person in query)
    Console.WriteLine(person);