using _00.Database;

var query = PersonGenerator.Generate().LastOrDefault();
Console.WriteLine(query);

query = PersonGenerator.Generate().LastOrDefault(p => p.Id == 2);
Console.WriteLine(query);

//Null
query = PersonGenerator.Generate().LastOrDefault(p => p.Id == 100);
Console.WriteLine(query == null ? "Not found" : query);