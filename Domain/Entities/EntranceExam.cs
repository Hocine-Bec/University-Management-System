namespace Domain.Entities
{
    /// <summary>
    /// Entrance examination with $50 fee, scoring out of 100, and pass/fail tracking
    /// </summary>
    public class EntranceExam
    {
        public int Id { get; set; }
        public DateTime ExamDate { get; set; }
        public decimal Score { get; set; }
        public bool IsPassed { get; set; }
        public decimal PaidFees { get; set; } = 50.00m;
        public string? ExamType { get; set; }
        public string? Notes { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

}

