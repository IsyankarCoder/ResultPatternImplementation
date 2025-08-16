public class UserList
{
    private static List<User> _users = new List<User>()
    {
       new User { Id = 1, Name = "John Doe", Email = "joh@gmail.com"},
    new User { Id = 2, Name = "Jane Smith", Email = "jane@gmail.com"},
    new User { Id = 3, Name = "Alice Johnson", Email = "alice@gmail.com"},
    new User { Id = 4, Name = "Bob Brown", Email = "bob@gmail.com"},
    new User { Id = 5, Name = "Emily Davis", Email = "emily@gmail.com"},
    new User { Id = 6, Name = "Michael Wilson", Email = "michael@gmail.com"},
    new User { Id = 7, Name = "Sophia Taylor", Email = "sophia@gmail.com"},
    new User { Id = 8, Name = "James Martinez", Email = "james@gmail.com"},
    new User { Id = 9, Name = "Olivia Garcia", Email = "olivia@gmail.com"},
    new User { Id = 10, Name = "William Rodriguez", Email = "william@gmail.com"}
    };

    public static IEnumerable<User> GetUsers()
    {
        return _users;
    }

    public static User? GetUser(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);

    }

    public static void AddUser(User user)
    {
        if (user != null && !_users.Any(u => u.Id == user.Id))
        {
            _users.Add(user);
        }
    }

    public static void UpdateUser(User user)
    {
        var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
        }
    }
}