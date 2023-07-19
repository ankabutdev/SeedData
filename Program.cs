using Microsoft.EntityFrameworkCore;
using SeedData;
using SeedData.Models;

namespace SeedDataExample;

class Program
{
    public static DataContext dbContext = new DataContext();

    static void Main(string[] args)
    {
        using (var dbContext = new DataContext())
        {
            //Delete(1, dbContext.Cars);
            //Update(2, "Avtobus", dbContext.Cars);
            //Read(dbContext.Cars);
            //Add(new Car { Name = "Bil" }, dbContext.Cars);

            //Delete(1, dbContext.Clients);
            //Update(2, "Alisher", dbContext.Clients);
            //Read(dbContext.Clients);
            //Add(new Client { Name = "Jamshid" }, dbContext.Clients);

            //Delete(1, dbContext.Buses);
            //Update(2, "Moshina_clone", dbContext.Buses);
            //Read(dbContext.Buses);
            //Add(new Bus { Name = "Qaysudur Bus" }, dbContext.Buses);

            // --------------------------------------------------

            //List<Car> allCars = GetAll(dbContext.Cars);

            //foreach (var item in allCars)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine(Get(2, dbContext.Cars).Name);


            //List<Client> allClients = GetAll(dbContext.Clients);
            //Client client = Get(2, dbContext.Clients);

            //foreach (var item in allClients)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine(Get(5, dbContext.Clients).Name);


            //List<Bus> allBuses = GetAll(dbContext.Buses);

            //foreach (var item in allBuses)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine(Get(7, dbContext.Buses).Name);

        }

    }

    static void Delete<T>(int id, DbSet<T> dbSet) where T : class
    {
        var entity = dbSet.Find(id);
        if (entity != null)
        {
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }
    }

    static void Update<T>(int id, string newName, DbSet<T> dbSet) where T : class
    {
        var entity = dbSet.Find(id);
        if (entity != null)
        {
            if (entity is Car car)
            {
                car.Name = newName;
            }
            else if (entity is Client client)
            {
                client.Name = newName;
            }
            else if (entity is Bus bus)
            {
                bus.Name = newName;
            }
            dbContext.SaveChanges();
        }
    }

    static void Read<T>(DbSet<T> dbSet) where T : class
    {
        var entities = dbSet.ToList();
        foreach (var entity in entities)
        {
            if (entity is Car car)
            {
                Console.WriteLine($"ID: {car.Id}, Name: {car.Name}");
            }
            else if (entity is Client client)
            {
                Console.WriteLine($"ID: {client.Id}, Name: {client.Name}");
            }
            else if (entity is Bus bus)
            {
                Console.WriteLine($"ID: {bus.Id}, Name: {bus.Name}");
            }
        }
    }

    static void Add<T>(T entity, DbSet<T> dbSet) where T : class
    {
        dbSet.Add(entity);
        dbContext.SaveChanges();
    }

    static List<T> GetAll<T>(DbSet<T> dbSet) where T : class
    {
        return dbSet.ToList();
    }

    static T Get<T>(int id, DbSet<T> dbSet) where T : class
    {
        return dbSet.Find(id)!;
    }
}
