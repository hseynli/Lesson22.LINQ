using _00.Database;

var query = PersonGenerator.Generate().FirstOrDefault(p => p.Salary > 10000, new Person() { Id = -1 });
Console.WriteLine(query);