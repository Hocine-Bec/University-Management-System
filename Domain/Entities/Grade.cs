namespace Domain.Entities
{
    /// <summary>
    /// Student academic performance tracking with course-specific grades.
    /// </summary>
    public class Grade
    {
        public int Id { get; set; }
        public float Score { get; set; }
        public DateTime? DateRecorded { get; set; }
        public string? Comments { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int SemesterId { get; set; }
        public Semester Semester { get; set; } = null!;
        public int? RegistrationId { get; set; }
        public Registration? Registration { get; set; }
    }

}

