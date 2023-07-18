using SeedData;
using SeedData.Models;

namespace SeedDataExample;

class Program
{
    public static DataContext dbContext = new DataContext();

    static void Main(string[] args)
    {


        //Add("Kimdur");
        //Update(2, "Komola Yo'ldosheva");
        //Delete(4);
        Read();
    }

    static void Delete(int id)
    {
        var person = dbContext.People.Find(id);
        if (person != null)
        {
            dbContext.People.Remove(person);
            dbContext.SaveChanges();
        }
    }


    static void Update(int id, string newName)
    {
        var p = dbContext.People.Find(id);
        p!.Name = newName;
        dbContext.SaveChanges();
    }

    static void Read()
    {
        var people = dbContext.People.ToList();
        foreach (var person in people)
            Console.WriteLine($"ID: {person.Id}, Name: {person.Name}");
    }

    static void Add(string name)
    {
        var person = new Person { Name = name };
        dbContext.People.Add(person);
        dbContext.SaveChanges();
    }

}
