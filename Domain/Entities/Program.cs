namespace Domain.Entities
{
    /// <summary>
    /// Academic program definition (BS, MS, PhD) with duration, fees, and age requirements
    /// </summary>
    public class Program
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int MinimumAge { get; set; }
        public int Duration { get; set; }
        public decimal Fees { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Enrollment> StudentEnrollments { get; set; } = new List<Enrollment>();
    }

}

