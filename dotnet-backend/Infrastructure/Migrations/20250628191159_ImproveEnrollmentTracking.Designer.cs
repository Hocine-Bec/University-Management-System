﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250628191159_ImproveEnrollmentTracking")]
    partial class ImproveEnrollmentTracking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasDatabaseName("ix_countries_code");

                    b.ToTable("countries", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DocsVerification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsApproved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_approved");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("notes");

                    b.Property<decimal>("PaidFees")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("paid_fees");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    b.Property<string>("RejectedReason")
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("rejected_reason");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("status");

                    b.Property<DateTime>("SubmissionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("submission_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("VerificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("verification_date");

                    b.Property<int?>("VerifiedByUserId")
                        .HasColumnType("integer")
                        .HasColumnName("verified_by_user_id");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("VerifiedByUserId");

                    b.ToTable("docs_verifications", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ActualGradDate")
                        .HasColumnType("date")
                        .HasColumnName("actual_grad_date");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("date")
                        .HasColumnName("enrollment_date");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("notes");

                    b.Property<int>("ProgramId")
                        .HasColumnType("integer")
                        .HasColumnName("program_id");

                    b.Property<int>("ServiceApplicationId")
                        .HasColumnType("integer")
                        .HasColumnName("service_application_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer")
                        .HasColumnName("student_id");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.HasIndex("ServiceApplicationId")
                        .IsUnique();

                    b.HasIndex("StudentId")
                        .IsUnique()
                        .HasDatabaseName("ix_enrollments_student_id");

                    b.ToTable("enrollments", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.EntranceExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("date")
                        .HasColumnName("exam_date");

                    b.Property<int>("ExamStatus")
                        .HasColumnType("integer")
                        .HasColumnName("exam_status");

                    b.Property<bool?>("IsPassed")
                        .HasColumnType("boolean")
                        .HasColumnName("is_passed");

                    b.Property<int>("MaxScore")
                        .HasColumnType("integer")
                        .HasColumnName("max_score");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("notes");

                    b.Property<decimal?>("PaidFees")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,2)")
                        .HasDefaultValue(50.00m)
                        .HasColumnName("paid_fees");

                    b.Property<int>("PassingScore")
                        .HasColumnType("integer")
                        .HasColumnName("passing_score");

                    b.Property<decimal?>("Score")
                        .HasColumnType("numeric(5,2)")
                        .HasColumnName("score");

                    b.HasKey("Id");

                    b.ToTable("entrance_exams", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Interview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("actual_end_time");

                    b.Property<bool>("IsApproved")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_approved");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("notes");

                    b.Property<decimal>("PaidFees")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("paid_fees");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("integer")
                        .HasColumnName("professor_id");

                    b.Property<string>("Recommendation")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("recommendation");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("scheduled_date_time");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("actual_start_time");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("interviews", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("address");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer")
                        .HasColumnName("country_id");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("first_name");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("image_path");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("LastName")
                        .HasDatabaseName("ix_persons_last_name");

                    b.ToTable("people", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AcademicRank")
                        .HasColumnType("integer")
                        .HasColumnName("academic_rank");

                    b.Property<string>("EmployeeNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("employee_number");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date")
                        .HasColumnName("hire_date");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("OfficeLocation")
                        .HasMaxLength(70)
                        .HasColumnType("varchar")
                        .HasColumnName("office_location");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("salary");

                    b.Property<string>("Specialization")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("specialization");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNumber")
                        .IsUnique()
                        .HasDatabaseName("ix_professors_employee_number");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("professors", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Program", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("code");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("description");

                    b.Property<int>("Duration")
                        .HasColumnType("integer")
                        .HasColumnName("duration");

                    b.Property<decimal>("Fees")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("fees");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<int>("MinimumAge")
                        .HasColumnType("integer")
                        .HasColumnName("minimum_age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasDatabaseName("ix_programs_code");

                    b.ToTable("programs", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ServiceApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ApplicationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("application_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("date")
                        .HasColumnName("completed_date");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("varchar");

                    b.Property<decimal>("PaidFees")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("paid_fees");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    b.Property<int?>("ProcessedByUserId")
                        .HasColumnType("integer")
                        .HasColumnName("processed_by_user_id");

                    b.Property<int>("ServiceOfferId")
                        .HasColumnType("integer")
                        .HasColumnName("service_id");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("ProcessedByUserId");

                    b.HasIndex("ServiceOfferId");

                    b.HasIndex("Status")
                        .HasDatabaseName("ix_service_applications_status");

                    b.ToTable("service_applications", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ServiceOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("description");

                    b.Property<decimal>("Fees")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("fees");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_services_name");

                    b.ToTable("service_offers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("date")
                        .HasColumnName("enrollment_date");

                    b.Property<DateTime?>("ExpectedGradDate")
                        .HasColumnType("date")
                        .HasColumnName("expected_graduation_date");

                    b.Property<string>("Notes")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar")
                        .HasColumnName("notes");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("student_number");

                    b.Property<int>("StudentStatus")
                        .HasColumnType("integer")
                        .HasColumnName("student_status");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasDatabaseName("ix_students_person_id");

                    b.HasIndex("StudentNumber")
                        .IsUnique()
                        .HasDatabaseName("ix_students_student_number");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_login_at");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("password");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasDatabaseName("ix_users_person_id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("ix_users_username");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DocsVerification", b =>
                {
                    b.HasOne("Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "VerifiedByUser")
                        .WithMany()
                        .HasForeignKey("VerifiedByUserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Person");

                    b.Navigation("VerifiedByUser");
                });

            modelBuilder.Entity("Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("Domain.Entities.Program", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ServiceApplication", "ServiceApplication")
                        .WithOne()
                        .HasForeignKey("Domain.Entities.Enrollment", "ServiceApplicationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("ServiceApplication");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.Entities.Interview", b =>
                {
                    b.HasOne("Domain.Entities.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Domain.Entities.Person", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_persons_country");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domain.Entities.Professor", b =>
                {
                    b.HasOne("Domain.Entities.Person", "Person")
                        .WithOne()
                        .HasForeignKey("Domain.Entities.Professor", "PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Entities.ServiceApplication", b =>
                {
                    b.HasOne("Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "ProcessedByUser")
                        .WithMany()
                        .HasForeignKey("ProcessedByUserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Domain.Entities.ServiceOffer", "ServiceOffer")
                        .WithMany()
                        .HasForeignKey("ServiceOfferId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("ProcessedByUser");

                    b.Navigation("ServiceOffer");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasOne("Domain.Entities.Person", "Person")
                        .WithOne()
                        .HasForeignKey("Domain.Entities.Student", "PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_person");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
