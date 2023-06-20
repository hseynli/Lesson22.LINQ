using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().SkipLast(5);

foreach (Person person in query)
    Console.WriteLine(person);