using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.CustomerMicroservice.Database.Entities;
using EasyMicroservices.CustomerMicroservice.Database.Entities.Releations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonRelationEntity>(entity =>
            {
                entity.HasKey(x => new { x.FromPersonId, x.ToPersonId });

                entity.HasOne(x => x.FromPerson)
                .WithMany(x => x.FromPersonRelations)
                .HasForeignKey(x => x.FromPersonId);

                entity.HasOne(x => x.ToPerson)
                .WithMany(x => x.ToPersonRelations)
                .HasForeignKey(x => x.ToPersonId);
            });


            base.AutoModelCreating(modelBuilder);
        }
    }
}