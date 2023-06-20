using _00.Database;

int query = PersonGenerator.Generate().Min(p => p.Salary);
Console.WriteLine(query);

query = PersonGenerator.Generate().Max(p => p.Salary);
Console.WriteLine(query);