﻿using AutoMapper;

namespace Applications.Mappers
{
    public partial class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyStudentMapping();
            ApplyCountryMapping();
            ApplyPersonMapping();
            ApplyUserMapping();
            ApplyProfessorMapping();
            ApplyServiceOfferMapping();
            ApplyProgramMapping();
            ApplyServiceApplicationMapping();
            ApplyDocsVerificationMapping();
            ApplyEntranceExamMapping();
            ApplyInterviewMapping();
        }

        //Method signatures
        partial void ApplyStudentMapping();
        partial void ApplyCountryMapping();
        partial void ApplyPersonMapping();
        partial void ApplyUserMapping();
        partial void ApplyProfessorMapping();
        partial void ApplyServiceOfferMapping();
        partial void ApplyProgramMapping();
        partial void ApplyServiceApplicationMapping();
        partial void ApplyDocsVerificationMapping();
        partial void ApplyEntranceExamMapping();
        partial void ApplyInterviewMapping();
    }
}
