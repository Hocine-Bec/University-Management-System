namespace Domain.Entities
{
    /// <summary>
    /// Student program enrollment with admission process tracking through document verification, entrance exam, and interview
    /// </summary>
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string? Notes { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int ProgramId { get; set; }
        public Program Program { get; set; } = null!;
        public int? DocumentVerificationId { get; set; }
        public DocumentVerification? DocumentVerification { get; set; }
        public int? EntranceExamId { get; set; }
        public EntranceExam? EntranceExam { get; set; }
        public int? InterviewId { get; set; }
        public Interview? Interview { get; set; }
    }

}

