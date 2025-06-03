using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// Central application entity for requesting university services with fee tracking and approval workflow
    /// </summary>
    public class ServiceApplication
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.UtcNow;
        public ApplicationStatus Status { get; set; } = ApplicationStatus.New;
        public decimal PaidFees { get; set; }
        public string? Notes { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int ApplicantId { get; set; }
        public Person Applicant { get; set; } = null!;
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
        public int? ProcessedByUserId { get; set; }
        public User? ProcessedByUser { get; set; }
        public int? SemesterId { get; set; }
        public Semester? Semester { get; set; }
    }

}

