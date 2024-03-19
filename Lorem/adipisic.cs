// To add a new item to the repository
public static void Items(Repository<TestClass> repo)
{
    TestClass newItem = new TestClass();
    // Set some properties of newItem here
    repo.Add(newItem);
}

// To remove an item from the repository by id
public static void Items(Repository<TestClass> repo)
{
    int id = 123; // The id of the item to remove
    repo.Remove(id);
}

// To query the repository for items that match some criteria
public static void Items(Repository<TestClass> repo)
{
    // Define some criteria here, such as name, age, etc.
    var query = repo.Where(item => item.Name == "Alice" && item.Age > 20);
    // Do something with the query result, such as printing, counting, etc.
    foreach (var item in query)
    {
        Console.WriteLine(item);
    }
}
