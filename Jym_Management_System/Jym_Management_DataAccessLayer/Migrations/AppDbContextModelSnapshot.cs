﻿// <auto-generated />
using System;
using Jym_Management_DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jym_Management_DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("PersonID");

                    b.Property<DateTime>("ResignationDate")
                        .HasColumnType("date")
                        .HasColumnName("resignationDate");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("EmployeeId")
                        .HasName("PK_tbk");

                    b.HasIndex("PersonId");

                    b.ToTable("tbEmployees", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbExerciseType", b =>
                {
                    b.Property<byte>("ExerciseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("ExerciseTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("ExerciseTypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ExerciseTypeId");

                    b.ToTable("tbExerciseTypes", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbJob", b =>
                {
                    b.Property<byte>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("JobID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("JobId"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("jobTitle");

                    b.HasKey("JobId");

                    b.ToTable("tbJobs", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbJobHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmpoyeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmpoyeeID");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<byte>("JobId")
                        .HasColumnType("tinyint")
                        .HasColumnName("JobID");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("tbJobHistories", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbMember", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MemberID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.Property<decimal?>("MemberWeight")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("PersonID");

                    b.HasKey("MemberId");

                    b.HasIndex("PersonId");

                    b.ToTable("tbMembers", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbPayrollPayment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("paymentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date")
                        .HasColumnName("paymentDate");

                    b.HasKey("PaymentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("tbPayroll_payments", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbPeriod", b =>
                {
                    b.Property<byte>("PeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("PeriodID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("PeriodId"), 1L, 1);

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time(0)");

                    b.Property<string>("PeriodName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time(0)");

                    b.HasKey("PeriodId");

                    b.ToTable("tbPeriods", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbPerson", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PersonID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Idcard")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("IDCard");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("PersonId");

                    b.HasIndex(new[] { "PhoneNumber" }, "UniquePhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("tbPerson", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbSubsciptionPeriod", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("smallmoney");

                    b.HasKey("Id");

                    b.ToTable("tbSubsciptionPeriods", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbSubscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SubscriptionID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionId"), 1L, 1);

                    b.Property<int>("CoachId")
                        .HasColumnType("int")
                        .HasColumnName("CoachID");

                    b.Property<int>("CreatedByReceptionistId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedByReceptionistID");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<byte>("ExcerciseTypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("ExcerciseTypeID");

                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("MemberID");

                    b.Property<byte>("PeriodId")
                        .HasColumnType("tinyint")
                        .HasColumnName("PeriodID");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<byte>("SubscriptionPeriodId")
                        .HasColumnType("tinyint")
                        .HasColumnName("SubscriptionPeriodID");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("CoachId");

                    b.HasIndex("CreatedByReceptionistId");

                    b.HasIndex("ExcerciseTypeId");

                    b.HasIndex("MemberId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("SubscriptionPeriodId");

                    b.ToTable("tbSubscriptions", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbSubscriptionPayment", b =>
                {
                    b.Property<int?>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("PaymentId"), 1L, 1);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int")
                        .HasColumnName("CreatedByUserID");

                    b.Property<decimal?>("PaymentAmount")
                        .HasColumnType("smallmoney");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int")
                        .HasColumnName("SubscriptionID");

                    b.HasKey("PaymentId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("tbSubscriptionPayments", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbPerson", "Person")
                        .WithOne("User")
                        .HasForeignKey("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbEmployee", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbPerson", "Person")
                        .WithMany("TbEmployees")
                        .HasForeignKey("PersonId")
                        .IsRequired()
                        .HasConstraintName("FK_Employees");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbJobHistory", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbJob", "Job")
                        .WithMany("TbJobHistories")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK_tbJobHistories_tbJobs");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbMember", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbPerson", "Person")
                        .WithMany("TbMembers")
                        .HasForeignKey("PersonId")
                        .IsRequired()
                        .HasConstraintName("FK_Members");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbPayrollPayment", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbEmployee", "Employee")
                        .WithMany("TbPayrollPayments")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_Payroll_payments");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbSubscription", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbJobHistory", "Coach")
                        .WithMany("TbSubscriptionCoaches")
                        .HasForeignKey("CoachId")
                        .IsRequired()
                        .HasConstraintName("FK_tbSubscriptions_tbJobHistories_Coach");

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbJobHistory", "CreatedByReceptionist")
                        .WithMany("TbSubscriptionCreatedByReceptionists")
                        .HasForeignKey("CreatedByReceptionistId")
                        .IsRequired()
                        .HasConstraintName("FK_tbSubscriptions_tbJobHistoriesRecep");

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbExerciseType", "ExcerciseType")
                        .WithMany("TbSubscriptions")
                        .HasForeignKey("ExcerciseTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_tbSubscriptions_tbExerciseType");

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbMember", "Member")
                        .WithMany("TbSubscriptions")
                        .HasForeignKey("MemberId")
                        .IsRequired()
                        .HasConstraintName("FK_tbSubscriptions_tbMember");

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbPeriod", "Period")
                        .WithMany("TbSubscriptions")
                        .HasForeignKey("PeriodId")
                        .IsRequired()
                        .HasConstraintName("FK_tbSubscriptions_tbPeriod");

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbSubsciptionPeriod", "SubscriptionPeriod")
                        .WithMany("TbSubscriptions")
                        .HasForeignKey("SubscriptionPeriodId")
                        .IsRequired()
                        .HasConstraintName("FK_tbSubscriptions_tbSubscriptionPeriod");

                    b.Navigation("Coach");

                    b.Navigation("CreatedByReceptionist");

                    b.Navigation("ExcerciseType");

                    b.Navigation("Member");

                    b.Navigation("Period");

                    b.Navigation("SubscriptionPeriod");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbSubscriptionPayment", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .HasConstraintName("FK_tbSubscriptionPayments_AspNetUsers");

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.TbSubscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .HasConstraintName("FK_tbSubscriptionPayments_tbSubscriptions");

                    b.Navigation("CreatedByUser");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Jym_Management_DataAccessLayer.Entities.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbEmployee", b =>
                {
                    b.Navigation("TbPayrollPayments");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbExerciseType", b =>
                {
                    b.Navigation("TbSubscriptions");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbJob", b =>
                {
                    b.Navigation("TbJobHistories");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbJobHistory", b =>
                {
                    b.Navigation("TbSubscriptionCoaches");

                    b.Navigation("TbSubscriptionCreatedByReceptionists");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbMember", b =>
                {
                    b.Navigation("TbSubscriptions");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbPeriod", b =>
                {
                    b.Navigation("TbSubscriptions");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbPerson", b =>
                {
                    b.Navigation("TbEmployees");

                    b.Navigation("TbMembers");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Jym_Management_DataAccessLayer.Entities.TbSubsciptionPeriod", b =>
                {
                    b.Navigation("TbSubscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
