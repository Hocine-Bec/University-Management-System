using Domain.Enums;

namespace Domain.Entities
{
    /// <summary>
    /// Faculty member entity extending Person with employment and academic ranking details
    /// </summary>
    public class Professor : Person
    {
        public required string EmployeeNumber { get; set; } = Guid.NewGuid().ToString();
        public AcademicRank AcademicRank { get; set; }
        public DateTime HireDate { get; set; }
        public string? Specialization { get; set; }
        public string? OfficeLocation { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; } = true;
        public int? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Section> TaughtSections { get; set; } = new List<Section>();
        public ICollection<Interview> ConductedInterviews { get; set; } = new List<Interview>();
    }

}

