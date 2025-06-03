namespace Domain.Entities
{
    /// <summary>
    /// Student registration for course sections with fee tracking and semester-specific enrollment
    /// </summary>
    public class Registration
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public decimal RegistrationFees { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int SectionId { get; set; }
        public Section Section { get; set; } = null!;
        public int SemesterId { get; set; }
        public Semester Semester { get; set; } = null!;
        public int? ProcessedByUserId { get; set; }
        public User? ProcessedByUser { get; set; }
    }

}

