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

#if (NET6_0)
namespace EasyMicroservices.CustomerMicroservice.Database.Contexts
{
    using System.ComponentModel.Design.Serialization;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    /// <summary>
    /// Provides a type converter to convert <see cref='System.DateOnly'/> objects to and from various other representations.
    /// </summary>
    public class DateOnlyConverter : TypeConverter
    {
        /// <summary>
        /// Gets a value indicating whether this converter can convert an object in the given source type to a <see cref='System.DateOnly'/>
        /// object using the specified context.
        /// </summary>
        /// <inheritdoc />
        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        /// <inheritdoc />
        public override bool CanConvertTo(ITypeDescriptorContext? context, [NotNullWhen(true)] Type? destinationType)
        {
            return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// Converts the given value object to a <see cref='System.DateOnly'/> object.
        /// </summary>
        /// <inheritdoc />
        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            if (value is string text)
            {
                text = text.Trim();
                if (text.Length == 0)
                {
                    return DateOnly.MinValue;
                }

                try
                {
                    // See if we have a culture info to parse with. If so, then use it.
                    DateTimeFormatInfo? formatInfo = null;

                    if (culture != null)
                    {
                        formatInfo = (DateTimeFormatInfo?)culture.GetFormat(typeof(DateTimeFormatInfo));
                    }

                    if (formatInfo != null)
                    {
                        return DateOnly.Parse(text, formatInfo);
                    }
                    else
                    {
                        return DateOnly.Parse(text, culture);
                    }
                }
                catch (FormatException e)
                {
                    throw new FormatException("SR.Format(SR.ConvertInvalidPrimitive, (string)value, nameof(DateOnly))", e);
                }
            }

            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts the given value object from a <see cref='System.DateOnly'/> object using the arguments.
        /// </summary>
        /// <inheritdoc />
        public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is DateOnly dateOnly)
            {
                if (dateOnly == DateOnly.MinValue)
                {
                    return string.Empty;
                }

                culture ??= CultureInfo.CurrentCulture;

                DateTimeFormatInfo? formatInfo = (DateTimeFormatInfo?)culture.GetFormat(typeof(DateTimeFormatInfo));

                if (culture == CultureInfo.InvariantCulture)
                {
                    return dateOnly.ToString("yyyy-MM-dd", culture);
                }

                string format = formatInfo!.ShortDatePattern;

                return dateOnly.ToString(format, CultureInfo.CurrentCulture);
            }

            if (destinationType == typeof(InstanceDescriptor) && value is DateOnly date)
            {
                return new InstanceDescriptor(typeof(DateOnly).GetConstructor(new Type[] { typeof(int), typeof(int), typeof(int) }), new object[] { date.Year, date.Month, date.Day });
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
#endif