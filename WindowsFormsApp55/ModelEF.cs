using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp55
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product_incom> Product_incoms { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Sail> Sails { get; set; }
        public virtual DbSet<Substance> Substances { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Product_incom)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.Login_FK);

            modelBuilder.Entity<Product_incom>()
                .Property(e => e.seller)
                .IsUnicode(false);

            modelBuilder.Entity<Product_incom>()
                .Property(e => e.value)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product_incom>()
                .Property(e => e.Login_FK)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Patient_name)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.doctor)
                .IsUnicode(false);

            modelBuilder.Entity<Sail>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Sail>()
                .HasOptional(e => e.Receipt)
                .WithRequired(e => e.Sail);

            modelBuilder.Entity<Sail>()
                .HasOptional(e => e.Substance)
                .WithRequired(e => e.Sail);

            modelBuilder.Entity<Substance>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Substance>()
                .Property(e => e.Manufacturer)
                .IsUnicode(false);

            modelBuilder.Entity<Substance>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Substance>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}
