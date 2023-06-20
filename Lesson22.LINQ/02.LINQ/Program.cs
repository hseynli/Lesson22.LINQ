using _00.Database;

var query = PersonGenerator.Generate().FirstOrDefault();
Console.WriteLine(query);

query = PersonGenerator.Generate().FirstOrDefault(p => p.Id == 2);
Console.WriteLine(query);

//NUll
query = PersonGenerator.Generate().FirstOrDefault(p => p.Id == 100);
Console.WriteLine(query == null ? "Not found" : query);