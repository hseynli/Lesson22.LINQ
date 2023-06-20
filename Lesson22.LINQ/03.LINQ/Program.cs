using _00.Database;

var query = PersonGenerator.Generate().Last();
Console.WriteLine(query);

query = PersonGenerator.Generate().Last(p => p.Id == 2);
Console.WriteLine(query);

//Exception
query = PersonGenerator.Generate().Last(p => p.Id == 100);
Console.WriteLine(query);