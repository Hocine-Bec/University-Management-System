namespace Domain.Entities
{
    /// <summary>
    /// Academic semester/term with registration periods and course scheduling
    /// </summary>
    public class Semester
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Year { get; set; }
        public required string Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RegistrationStartDate { get; set; }
        public DateTime? RegistrationEndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Section> Sections { get; set; } = new List<Section>();
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }

}

