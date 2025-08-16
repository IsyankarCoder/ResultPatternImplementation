public interface IUserService
{
   Task<Result<IEnumerable<User>>> GetUsersAsync();

    Task<Result<User>> GetUserAsync(int id);

    Task<Result> CreateUserAsync(User user);

    Task<Result> UpdateUserAsync(User user);
}