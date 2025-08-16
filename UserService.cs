public class UserService:IUserService
{
    public Task<Result<IEnumerable<User>>> GetUsersAsync()
    {
        var users = UserList.GetUsers();
        return Task.FromResult(Result.Success(users));
    }

    public Task<Result<User>> GetUserAsync(int id)
    {
        var user = UserList.GetUser(id);
        if (user == null)
        {
            return Task.FromResult(Result.Failure<User>($"User with ID {id} not found"));
        }
        return Task.FromResult(Result.Success(user));
    }

    public Task<Result> CreateUserAsync(User user)
    {
        if (user is null)
        {
            return Task.FromResult(Result.Failure("User is null"));
        }

        UserList.AddUser(user);
        return Task.FromResult(Result.Success());
    }

    public  Task<Result> UpdateUserAsync(User user)
    {
        if (user == null || user.Id <= 0)
        {
            return Task.FromResult(Result.Failure("User is null or has an invalid ID"));
        }

        UserList.UpdateUser(user);
        return Task.FromResult(Result.Success());
    }
}