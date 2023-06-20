using _00.Database;

var query = PersonGenerator.Generate().First();
Console.WriteLine(query);

query = PersonGenerator.Generate().First(p => p.Id == 2);
Console.WriteLine(query);

//Exception
//query = PersonGenerator.Generate().First(p => p.Id == 100);
//Console.WriteLine(query);