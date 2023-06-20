using _00.Database;

var query = (from person in PersonGenerator.Generate()
            where person.Name == "Farid"
            select person).FirstOrDefault();
Console.WriteLine(query);