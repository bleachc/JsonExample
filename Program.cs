using System.Text.Json;

namespace JsonExample;

class Program
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Pets { get; set; }
    }

    public static void Main(string[] args)
    {
        var collection = new List<Person>();
        var ben = new Person
        {
            FirstName = "Ben",
            LastName = "Leach",
            Pets = new List<string>
            {
                "Winnie"
            }
        };
        var bob = new Person
        {
            FirstName = "Bob",
            LastName = "Noname",
            Pets = new List<string>
            {
                "Spot"
            }
        };
        collection.Add(ben);
        collection.Add(bob);

        var result = JsonSerializer.Serialize(collection);

        Console.WriteLine(result);

        var persons = JsonSerializer.Deserialize<List<Person>>(result);

        foreach (var p in persons)
        {
            Console.WriteLine(p.FirstName);
        }
    }
}