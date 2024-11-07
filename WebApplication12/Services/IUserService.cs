using WebApplication12.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication12.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task AddUserAsync(User user);
    }
}
