using _00.Database;

//Exception
Person query;// = PersonGenerator.Generate().Single();
//Console.WriteLine(query);

query = PersonGenerator.Generate().SingleOrDefault(p => p.Id == 1);
Console.WriteLine(query);