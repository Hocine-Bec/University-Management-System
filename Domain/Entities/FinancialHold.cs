namespace Domain.Entities
{
    /// <summary>
    /// Financial holds preventing student registration and services until outstanding balances are resolved
    /// </summary>
    public class FinancialHold
    {
        public int Id { get; set; }
        public required string Reason { get; set; }
        public decimal HoldAmount { get; set; }
        public DateTime DatePlaced { get; set; } = DateTime.UtcNow;
        public DateTime? DateResolved { get; set; }
        public bool IsActive { get; set; } = true;
        public string? ResolutionNotes { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int PlacedByUserId { get; set; }
        public User PlacedByUser { get; set; } = null!;
        public int? ResolvedByUserId { get; set; }
        public User? ResolvedByUser { get; set; }
    }

}

