using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// Student entity extending Person with academic-specific properties. Manages enrollment status and academic progression.
    /// </summary>
    public class Student : Person
    {
        public required string StudentNumber { get; set; } = Guid.NewGuid().ToString();
        public StudentStatus Status { get; set; } = StudentStatus.Active;
        public DateTime EnrollmentDate { get; set; }
        public DateTime? ExpectedGradDate { get; set; }
        public string? Notes { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public ICollection<FinancialHold> FinancialHolds { get; set; } = new List<FinancialHold>();
    }

}

