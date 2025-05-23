﻿namespace Applications.DTOs
{
    public record StudentDto
    {
        public int Id { get; init; }
        public string? FName { get; init; }
        public string? LName { get; init; }

        public ICollection<SectionDto> Sections { get; init; } = new List<SectionDto>();
    }
}
