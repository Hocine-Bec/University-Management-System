﻿using AutoMapper;

namespace Applications.Mappers
{
    public partial class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyStudentMapping();
        }

        //Method signatures
        partial void ApplyStudentMapping();
    }

  
}
