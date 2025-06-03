namespace Domain.Entities
{
    /// <summary>
    /// Admission interview conducted by faculty with $75 fee and approval recommendation
    /// </summary>
    public class Interview
    {
        public int Id { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public bool IsApproved { get; set; }
        public decimal PaidFees { get; set; } = 75.00m;
        public string? InterviewNotes { get; set; }
        public string? Recommendation { get; set; }
        public int? ProfessorId { get; set; }
        public Professor? Professor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

}

