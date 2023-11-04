using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp26.DataEntity;

public partial class ErpContext : DbContext
{
    public ErpContext()
    {
    }

    public ErpContext(DbContextOptions<ErpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseBranchInfo> CourseBranchInfos { get; set; }

    public virtual DbSet<CourseSubject> CourseSubjects { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    public virtual DbSet<FeesType> FeesTypes { get; set; }

    public virtual DbSet<LeadSource> LeadSources { get; set; }

    public virtual DbSet<LeadType> LeadTypes { get; set; }

    public virtual DbSet<PackageMaster> PackageMasters { get; set; }

    public virtual DbSet<PackageMasterDetailsInfo> PackageMasterDetailsInfos { get; set; }

    public virtual DbSet<PaymentMode> PaymentModes { get; set; }

    public virtual DbSet<RoleType> RoleTypes { get; set; }

    public virtual DbSet<StateInfo> StateInfos { get; set; }

    public virtual DbSet<SubjectMaster> SubjectMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DIVYESH\\SQLEXPRESS;Database=ERP;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Batch>(entity =>
        {
            entity.ToTable("Batch");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Batch1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Batch");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Timing)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Country1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Country");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Course1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Course");
        });

        modelBuilder.Entity<CourseBranchInfo>(entity =>
        {
            entity.ToTable("CourseBranchInfo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
        });

        modelBuilder.Entity<CourseSubject>(entity =>
        {
            entity.ToTable("CourseSubject");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.ToTable("Designation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.ToTable("Education");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EducationName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("EmployeeInfo");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.WhatupNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FeesType>(entity =>
        {
            entity.ToTable("FeesType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FeesTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeadSource>(entity =>
        {
            entity.ToTable("LeadSource");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeadType>(entity =>
        {
            entity.ToTable("LeadType");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PackageMaster>(entity =>
        {
            entity.ToTable("PackageMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PackageTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageTitleInternal)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PackageMasterDetailsInfo>(entity =>
        {
            entity.HasKey(e => e.PackageMaterDetailsId);

            entity.ToTable("PackageMasterDetailsInfo");

            entity.Property(e => e.PackageMaterDetailsId).HasColumnName("PackageMaterDetailsID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PackageMasterId).HasColumnName("PackageMasterID");
        });

        modelBuilder.Entity<PaymentMode>(entity =>
        {
            entity.ToTable("PaymentMode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PaymentMode");
        });

        modelBuilder.Entity<RoleType>(entity =>
        {
            entity.ToTable("RoleType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.RoleType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RoleType");
        });

        modelBuilder.Entity<StateInfo>(entity =>
        {
            entity.ToTable("StateInfo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubjectMaster>(entity =>
        {
            entity.ToTable("SubjectMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
