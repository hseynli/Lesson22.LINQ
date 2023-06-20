namespace _00.Database
{
    public static class PersonGenerator
    {
        public static IEnumerable<Person> Generate()
        {
            return new Person[]
            {
                new Person() { Id = 1, Name = "Farid", Surname = "Huseynli", City = "Baku", Salary = 1000, BirthDate = DateOnly.Parse("17-09-1994")},
                new Person() { Id = 2, Name = "Cavid", Surname = "Kazimov", City = "Ganja", Salary = 1500, BirthDate = DateOnly.Parse("18-03-1987")},
                new Person() { Id = 3, Name = "Hesen", Surname = "Abbasov", City = "Masalli", Salary = 700, BirthDate = DateOnly.Parse("14-05-1998")},
                new Person() { Id = 4, Name = "Fariq", Surname = "Nesirov", City = "Lankaran", Salary = 800, BirthDate = DateOnly.Parse("01-09-1950")},
                new Person() { Id = 5, Name = "Hesen", Surname = "Hesenov", City = "Sumqayit", Salary = 2500, BirthDate = DateOnly.Parse("30-06-1967")},
                new Person() { Id = 6, Name = "Aygun", Surname = "Huseynli", City = "Baku", Salary = 1000, BirthDate = DateOnly.Parse("05-07-2000")},
                new Person() { Id = 7, Name = "Farid", Surname = "Huseynli", City = "Baku", Salary = 1500, BirthDate = DateOnly.Parse("17-09-1994")},
            };
        }        
    }
}