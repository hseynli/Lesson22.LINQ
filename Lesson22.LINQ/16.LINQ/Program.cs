using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().SkipWhile(p => p.Id <= 3);

foreach (Person person in query)
    Console.WriteLine(person);