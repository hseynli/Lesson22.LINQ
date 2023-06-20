using _00.Database;

int query = PersonGenerator.Generate().Count();
Console.WriteLine(query);

query = PersonGenerator.Generate().Count(p => p.Name == "Farid");
Console.WriteLine(query);