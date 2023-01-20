using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace demoHRMS.Models
{
    public partial class demoDBHRContext : DbContext
    {
        public demoDBHRContext()
        {
        }

        public demoDBHRContext(DbContextOptions<demoDBHRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Hr> Hr { get; set; }
        public virtual DbSet<Salary> Salary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AU9L76D\\SQLEXPRESS;Database=demoDBHR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => new { e.IdEmployee, e.IdAttendance })
                    .HasName("PK_ATTENDANCE");

                entity.HasIndex(e => e.IdAttendance)
                    .HasName("AK_IDENTIFIER_1_ATTENDAN")
                    .IsUnique();

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("ASSOCIATION3_FK");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("idEmployee")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdAttendance)
                    .HasColumnName("idAttendance")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Absences).HasColumnName("absences");

                entity.Property(e => e.Clockin)
                    .HasColumnName("clockin")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Clockout)
                    .HasColumnName("clockout")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATTENDAN_ASSOCIATI_EMPLOYEE");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK_EMPLOYEE");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("idEmployee")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cin)
                    .HasColumnName("cin")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hr>(entity =>
            {
                entity.HasKey(e => e.IdHr)
                    .HasName("PK_HR");

                entity.Property(e => e.IdHr)
                    .HasColumnName("idHR")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Hrpassword)
                    .HasColumnName("hrpassword")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Hrusername)
                    .HasColumnName("hrusername")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => new { e.IdEmployee, e.IdSalary })
                    .HasName("PK_SALARY");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("ASSOCIATION1_FK");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("idEmployee")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSalary)
                    .HasColumnName("idSalary")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HoursWorked).HasColumnName("hoursWorked");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Taxes)
                    .HasColumnName("taxes")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TypeSalary).HasColumnName("typeSalary");

                entity.Property(e => e.Validation).HasColumnName("validation");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Salary)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALARY_ASSOCIATI_EMPLOYEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
