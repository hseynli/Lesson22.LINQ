using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().TakeLast(3);

foreach (Person person in query)
    Console.WriteLine(person);