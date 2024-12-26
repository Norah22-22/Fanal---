using System;

public class User
{
    public string Name { get; set; }
    public int ID { get; private set; }
    private static int totalUsers = 0;
    private static int nextID = 1;

    public User(string name)
    {
        totalUsers++;
        this.ID = nextID++;
        this.Name = string.IsNullOrEmpty(name) ? "No Name Provided" : name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}");
    }

    public static void DisplayTotalUsers()
    {
        Console.WriteLine($"Total Users: {totalUsers}");
    }
}

public class Program
{
    public static void Main()
    {
        User user1 = new User("Norah");
        User user2 = new User("Sara");
        User user3 = new User(null);

        user1.DisplayInfo();
        user2.DisplayInfo();
        user3.DisplayInfo();

        User.DisplayTotalUsers();

        User? userNull = null;
        if (userNull != null)
        {
            userNull.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Null");
        }
    }
}

