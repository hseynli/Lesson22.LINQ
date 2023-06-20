using _00.Database;

IOrderedEnumerable<Person> query = PersonGenerator.Generate().OrderBy(p => p.Name).ThenBy(p => p.Salary);

foreach (Person person in query)
    Console.WriteLine(person);