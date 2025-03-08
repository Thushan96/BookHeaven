using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookHeaven2.Data;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BookstoreDbContext _context;

        public UserRepository(BookstoreDbContext context)
        {
            _context = context;
        }

        public async Task<AppUser?> GetByIdAsync(Guid userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<AppUser?> GetByUsernameAsync(string username)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<IEnumerable<AppUser>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task CreateAsync(AppUser user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<int?> UpdateAsync(AppUser user)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser == null)
            {
                return null;
            }

            _context.Entry(existingUser).CurrentValues.SetValues(user);
            return await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<AppUser>> GetByRoleAsync(UserRole role)
        {
            return await _context.Users
                .Where(u => u.Role == role)
                .ToListAsync();
        }

        public async Task<AppUser?> ValidateUserAsync(string username, string passwordHash)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.PasswordHash == passwordHash);
        }

        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username);
        }
    }
}
