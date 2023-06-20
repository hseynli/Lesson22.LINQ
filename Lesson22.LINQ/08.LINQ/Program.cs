using _00.Database;

var query = PersonGenerator.Generate().Any();
Console.WriteLine(query);

query = PersonGenerator.Generate().Any(p => p.Salary > 10000);
Console.WriteLine(query);

query = PersonGenerator.Generate().Any(p => p.Salary > 500);
Console.WriteLine(query);