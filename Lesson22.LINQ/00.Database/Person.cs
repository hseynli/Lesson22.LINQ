public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Salary { get; set; }
    public DateOnly BirthDate { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return $"{Id} {Name} {Surname} {Salary} {BirthDate} {City}";
    }
}