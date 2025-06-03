namespace Domain.Entities
{
    /// <summary>
    /// Document verification step in admission process with $25 fee and approval tracking
    /// </summary>
    public class DocumentVerification
    {
        public int Id { get; set; }
        public DateTime VerificationDate { get; set; }
        public bool IsApproved { get; set; }
        public decimal PaidFees { get; set; } = 25.00m;
        public string? Notes { get; set; }
        public string? VerifiedBy { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

}

