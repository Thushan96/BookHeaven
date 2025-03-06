namespace BookHeaven2.Data.Models
{
    public class AppUser  // Renamed class
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Admin,
        SalesClerk
    }
}
