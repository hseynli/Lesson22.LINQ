using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().Take(3);

foreach (Person person in query)
    Console.WriteLine(person);

Console.WriteLine(new string('-', 80));

query = PersonGenerator.Generate().Skip(2).Take(3);

foreach (Person person in query)
    Console.WriteLine(person);