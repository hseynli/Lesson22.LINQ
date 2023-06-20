int[] numbers = { 1, 2, 5, 6, 77, 5, 4, 67, 90 };
IEnumerable<int> query = numbers.Distinct();

foreach (int person in query)
    Console.WriteLine(person);