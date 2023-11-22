using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.Database.Entities.Releations;
using EasyMicroservices.CustomerMicroservice.Database.Schemas;
using EasyMicroservices.Domain.DataTypes;
using System;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities
{
    public class PersonEntity : PersonSchema, IIdSchema<long>
    {
        public long Id { get; set; }
        public string NationalCode { get; set; }
        /// <summary>
        /// جنسیت شخص
        /// </summary>
        public GenderType? GenderType { get; set; }
        /// <summary>
        /// ملیت 
        /// </summary>
        public NationalityType? NationalityType { get; set; }
        /// <summary>
        /// وضعیت تاهل
        /// </summary>
        public MaritalStatusType? MaritalStatus { get; set; }
        public DateOnly? BirthDate { get; set; }

        public long? CategoryId { get; set; }
        public PersonCategoryEntity Category { get; set; }

        public ICollection<AddressEntity> Addresses { get; set; }
        public ICollection<EmailEntity> Emails { get; set; }
        public ICollection<PassportEntity> Passports { get; set; }
        public ICollection<PhoneEntity> Phones { get; set; }
        public ICollection<CertificationEntity> Certifications { get; set; }
        public ICollection<VisaEntity> Visas { get; set; }
        public ICollection<PersonRelationEntity> FromPersonRelations { get; set; }
        public ICollection<PersonRelationEntity> ToPersonRelations { get; set; }
    }
}

