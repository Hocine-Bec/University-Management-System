using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// System user account linking a person to system access with role-based permissions
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;
        public ICollection<ServiceApplication> ProcessedApplications { get; set; } = new List<ServiceApplication>();
        public ICollection<Registration> ProcessedRegistrations { get; set; } = new List<Registration>();
        public ICollection<FinancialHold> CreatedFinancialHolds { get; set; } = new List<FinancialHold>();
    }

}

