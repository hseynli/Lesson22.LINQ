using _00.Database;

double query = PersonGenerator.Generate().Average(p => p.Salary);
Console.WriteLine(query);