﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmsCoreApi.Data;

namespace SmsCoreApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210225172037_kjkjkj")]
    partial class kjkjkj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmsCoreApi.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AttendDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("AttendanceID");

                    b.HasIndex("StudentID");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("SmsCoreApi.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            CityName = "Chittagong"
                        },
                        new
                        {
                            CityID = 2,
                            CityName = "Dhaka"
                        },
                        new
                        {
                            CityID = 3,
                            CityName = "Barishal"
                        });
                });

            modelBuilder.Entity("SmsCoreApi.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = 1,
                            CountryName = "Bangladesh"
                        },
                        new
                        {
                            CountryID = 2,
                            CountryName = "Pakistan"
                        },
                        new
                        {
                            CountryID = 3,
                            CountryName = "Australia"
                        });
                });

            modelBuilder.Entity("SmsCoreApi.Models.Designation", b =>
                {
                    b.Property<int>("DesignationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesignationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DesignationID");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("SmsCoreApi.Models.EmpJobHistory", b =>
                {
                    b.Property<int>("EmpJobHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<int>("DesignationID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmpJobHistoryID");

                    b.HasIndex("BranchID");

                    b.HasIndex("DesignationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmpJobHistories");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesignationID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("BranchID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("DesignationID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Paid")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentTypeID")
                        .HasColumnType("int");

                    b.Property<int>("StudentRegistrationID")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("PaymentTypeID");

                    b.HasIndex("StudentRegistrationID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("SmsCoreApi.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ClassInfoID")
                        .HasColumnType("int");

                    b.Property<int?>("SClassID")
                        .HasColumnType("int");

                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeID");

                    b.HasIndex("SClassID");

                    b.HasIndex("SessionID");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("SmsCoreApi.Models.SClass", b =>
                {
                    b.Property<int>("SClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SClassID");

                    b.ToTable("SClass");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SClassID")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("SectionID");

                    b.HasIndex("SClassID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Session", b =>
                {
                    b.Property<int>("SessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SessionID");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<string>("Roll")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SClassID")
                        .HasColumnType("int");

                    b.Property<int>("SectionID")
                        .HasColumnType("int");

                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<int>("StudentRegistrationID")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("SClassID");

                    b.HasIndex("SectionID");

                    b.HasIndex("SessionID");

                    b.HasIndex("StudentRegistrationID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SmsCoreApi.Models.StudentRegistration", b =>
                {
                    b.Property<int>("StudentRegistrationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GurdianPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentRegistrationID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("StudentRegistration");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.HasIndex("GroupID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("TeacherID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Attendance", b =>
                {
                    b.HasOne("SmsCoreApi.Models.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Branch", b =>
                {
                    b.HasOne("SmsCoreApi.Models.City", "City")
                        .WithMany("Branches")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Country", "Country")
                        .WithMany("Branches")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SmsCoreApi.Models.EmpJobHistory", b =>
                {
                    b.HasOne("SmsCoreApi.Models.Branch", "Branch")
                        .WithMany("EmpJobHistories")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Designation", "Designation")
                        .WithMany("EmpJobHistories")
                        .HasForeignKey("DesignationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Employee", "Employee")
                        .WithMany("EmpJobHistories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Designation");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Employee", b =>
                {
                    b.HasOne("SmsCoreApi.Models.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.City", "City")
                        .WithMany("Employees")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Country", "Country")
                        .WithMany("Employees")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Designation", "Designation")
                        .WithMany("Employees")
                        .HasForeignKey("DesignationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Payment", b =>
                {
                    b.HasOne("SmsCoreApi.Models.PaymentType", "PaymentType")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.StudentRegistration", "StudentRegistration")
                        .WithMany()
                        .HasForeignKey("StudentRegistrationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PaymentType");

                    b.Navigation("StudentRegistration");
                });

            modelBuilder.Entity("SmsCoreApi.Models.PaymentType", b =>
                {
                    b.HasOne("SmsCoreApi.Models.SClass", "SClass")
                        .WithMany("PaymentTypes")
                        .HasForeignKey("SClassID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SmsCoreApi.Models.Session", "Session")
                        .WithMany("PaymentTypes")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SClass");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Section", b =>
                {
                    b.HasOne("SmsCoreApi.Models.SClass", "SClass")
                        .WithMany("Sections")
                        .HasForeignKey("SClassID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SClass");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Student", b =>
                {
                    b.HasOne("SmsCoreApi.Models.Payment", "Payment")
                        .WithMany("Students")
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.SClass", "SClass")
                        .WithMany("Students")
                        .HasForeignKey("SClassID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Section", "Section")
                        .WithMany("Students")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Session", "Session")
                        .WithMany("Students")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.StudentRegistration", "StudentRegistration")
                        .WithMany("Students")
                        .HasForeignKey("StudentRegistrationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("SClass");

                    b.Navigation("Section");

                    b.Navigation("Session");

                    b.Navigation("StudentRegistration");
                });

            modelBuilder.Entity("SmsCoreApi.Models.StudentRegistration", b =>
                {
                    b.HasOne("SmsCoreApi.Models.City", "City")
                        .WithMany("StudentRegistrations")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Subject", b =>
                {
                    b.HasOne("SmsCoreApi.Models.Group", "Group")
                        .WithMany("Subjects")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Teacher", b =>
                {
                    b.HasOne("SmsCoreApi.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmsCoreApi.Models.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Branch", b =>
                {
                    b.Navigation("EmpJobHistories");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SmsCoreApi.Models.City", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Employees");

                    b.Navigation("StudentRegistrations");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Country", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Designation", b =>
                {
                    b.Navigation("EmpJobHistories");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Employee", b =>
                {
                    b.Navigation("EmpJobHistories");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Group", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Payment", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SmsCoreApi.Models.PaymentType", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("SmsCoreApi.Models.SClass", b =>
                {
                    b.Navigation("PaymentTypes");

                    b.Navigation("Sections");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Section", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Session", b =>
                {
                    b.Navigation("PaymentTypes");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Student", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("SmsCoreApi.Models.StudentRegistration", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SmsCoreApi.Models.Subject", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
