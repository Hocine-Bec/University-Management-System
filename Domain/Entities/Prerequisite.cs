namespace Domain.Entities
{
    /// <summary>
    /// Defines course prerequisites with minimum grade requirements for academic progression
    /// </summary>
    public class Prerequisite
    {
        public int Id { get; set; }
        public decimal MinimumGrade { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int PrerequisiteCourseId { get; set; }
        public Course PrerequisiteCourse { get; set; } = null!;
    }

}

