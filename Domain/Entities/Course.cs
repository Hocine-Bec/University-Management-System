namespace Domain.Entities
{
    /// <summary>
    /// Course definition with credit hours and prerequisites management
    /// </summary>
    public class Course
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public int CreditHours { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Section> Sections { get; set; } = new List<Section>();
        public ICollection<Prerequisite> Prerequisites { get; set; } = new List<Prerequisite>();
        public ICollection<Prerequisite> IsPrerequisiteFor { get; set; } = new List<Prerequisite>();
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }

}

