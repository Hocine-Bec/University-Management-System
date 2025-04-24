﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.OfficeName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.OfficeLocation)
               .HasColumnType("VARCHAR")
               .HasMaxLength(50)
               .IsRequired();


            builder.ToTable("Offices");

            builder.HasData(LoadOffices());
        }

        private List<Office> LoadOffices()
        {
            return new List<Office>()
            {
                new Office {Id = 1, OfficeName = "Off_05", OfficeLocation = "Building A"},
                new Office {Id = 2, OfficeName = "Off_12", OfficeLocation = "Building B"},
                new Office {Id = 3, OfficeName = "Off_32", OfficeLocation = "Administration"},
                new Office {Id = 4, OfficeName = "Off_44", OfficeLocation = "IT Department"},
                new Office {Id = 5, OfficeName = "Off_43", OfficeLocation = "IT Department"}
            };
        }
    }
}
