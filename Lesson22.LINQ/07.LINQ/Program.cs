using _00.Database;

var query = PersonGenerator.Generate().All(p => p.Salary > 10000);
Console.WriteLine(query);

query = PersonGenerator.Generate().All(p => p.Salary > 500);
Console.WriteLine(query);