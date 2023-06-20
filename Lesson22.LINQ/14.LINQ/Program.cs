using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().Skip(2);

foreach (Person person in query)
    Console.WriteLine(person);