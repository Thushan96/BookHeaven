using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<AppUser?> GetByIdAsync(Guid userId);

        Task<AppUser?> GetByUsernameAsync(string username);

        Task<IEnumerable<AppUser>> GetAllAsync();

        Task CreateAsync(AppUser user);

        Task UpdateAsync(AppUser user);

        Task DeleteAsync(Guid userId);

        Task<IEnumerable<AppUser>> GetByRoleAsync(UserRole role);

        Task<AppUser?> ValidateUserAsync(string username, string passwordHash);

        Task<bool> UsernameExistsAsync(string username);
    }
}
