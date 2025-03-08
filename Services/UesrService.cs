using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCrypt.Net;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        // Constructor to inject the repository dependency
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Get a user by their ID
        public async Task<AppUser?> GetUserByIdAsync(Guid userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        // Get a user by their username
        public async Task<AppUser?> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }

        // Get all users
        public async Task<IEnumerable<AppUser>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        // Create a new user with hashed password
        public async Task CreateUserAsync(AppUser user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            bool usernameExists = await _userRepository.UsernameExistsAsync(user.Username);
            if (usernameExists)
                throw new InvalidOperationException("Username already exists.");

            user.PasswordHash = HashPassword(user.PasswordHash);

            await _userRepository.CreateAsync(user);
        }

        public async Task<int?> UpdateUserAsync(AppUser user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (user.PasswordHash != null || user.PasswordHash != "") {
                user.PasswordHash = HashPassword(user.PasswordHash);
            }

            return await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            await _userRepository.DeleteAsync(userId);
        }

        public async Task<IEnumerable<AppUser>> GetUsersByRoleAsync(UserRole role)
        {
            return await _userRepository.GetByRoleAsync(role);
        }

        public async Task<AppUser?> ValidateUserAsync(string username, string plainPassword)
        {
            var user = await _userRepository.GetByUsernameAsync(username);
            if (user != null && VerifyPassword(plainPassword, user.PasswordHash))
            {
                return user; 
            }
            return null; 
        }

        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _userRepository.UsernameExistsAsync(username);
        }


        private string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        private bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }

    }
}
