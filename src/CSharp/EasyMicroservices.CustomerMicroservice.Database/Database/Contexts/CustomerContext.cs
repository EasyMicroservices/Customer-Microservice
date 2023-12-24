using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.CustomerMicroservice.Database.Entities;
using EasyMicroservices.CustomerMicroservice.Database.Entities.Releations;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;

namespace EasyMicroservices.CustomerMicroservice.Database.Contexts
{
    public class CustomerContext : RelationalCoreContext
    {
        public CustomerContext(IEntityFrameworkCoreDatabaseBuilder builder) : base(builder)
        {
        }

        public DbSet<PersonEntity> Persons { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<EmailEntity> Emails { get; set; }
        public DbSet<PassportEntity> Passports { get; set; }
        public DbSet<PhoneEntity> Phones { get; set; }
        public DbSet<CertificationEntity> Certifications { get; set; }
        public DbSet<VisaEntity> Visas { get; set; }
        public DbSet<PersonRelationEntity> PersonRelations { get; set; }
        public DbSet<PersonCategoryEntity> PersonCategories { get; set; }
        public DbSet<LinkEntity> Links { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                    .HaveConversion<DateOnlyConverter>()
                    .HaveColumnType("date");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonRelationEntity>(entity =>
            {
                entity.HasKey(x => new { x.FromPersonId, x.ToPersonId });

                entity.HasOne(x => x.FromPerson)
                .WithMany(x => x.FromPersonRelations)
                .HasForeignKey(x => x.FromPersonId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(x => x.ToPerson)
                .WithMany(x => x.ToPersonRelations)
                .HasForeignKey(x => x.ToPersonId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PersonEntity>()
                .Property(x => x.BirthDate)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToDateTime(TimeOnly.MinValue) : (DateTime?)null,
                    v => v.HasValue ? DateOnly.FromDateTime(v.Value) : (DateOnly?)null);

            modelBuilder.Entity<VisaEntity>()
                .Property(x => x.ExitDate)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToDateTime(TimeOnly.MinValue) : (DateTime?)null,
                    v => v.HasValue ? DateOnly.FromDateTime(v.Value) : (DateOnly?)null);

            modelBuilder.Entity<VisaEntity>()
                .Property(x => x.EntryDate)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToDateTime(TimeOnly.MinValue) : (DateTime?)null,
                    v => v.HasValue ? DateOnly.FromDateTime(v.Value) : (DateOnly?)null);

            base.AutoModelCreating(modelBuilder);
        }
    }
}