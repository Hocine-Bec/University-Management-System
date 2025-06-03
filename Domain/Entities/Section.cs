namespace Domain.Entities
{
    /// <summary>
    /// Specific course offering with schedule, capacity, and instructor assignment
    /// </summary>
    public class Section
    {
        public int Id { get; set; }
        public required string SectionNumber { get; set; }
        public string? MeetingDays { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Classroom { get; set; }
        public int MaxCapacity { get; set; }
        public int CurrentEnrollment { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int SemesterId { get; set; }
        public Semester Semester { get; set; } = null!;
        public int? ProfessorId { get; set; }
        public Professor? Professor { get; set; }
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }

}

