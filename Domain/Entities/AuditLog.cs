namespace Domain.Entities
{
    /// <summary>
    /// System audit trail tracking user actions, entity changes, and timestamps for accountability and compliance
    /// </summary>
    public class AuditLog
    {
        public int Id { get; set; }
        public required string Action { get; set; }
        public required string EntityType { get; set; }
        public int EntityId { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string? IPAddress { get; set; }
        public string? UserAgent { get; set; }
    }

}

