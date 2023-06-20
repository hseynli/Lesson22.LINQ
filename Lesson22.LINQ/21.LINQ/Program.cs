using _00.Database;

IEnumerable<Person> query = PersonGenerator.Generate().Union(new List<Person>()
                                { new Person() { Id = -1, Name = "Test name", Surname = "Test surname", BirthDate = DateOnly.Parse("12-01-1985")}});

foreach (Person person in query)
    Console.WriteLine(person);