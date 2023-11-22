using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.Database.Entities.Releations;
using EasyMicroservices.CustomerMicroservice.Database.Schemas;
using EasyMicroservices.CustomerMicroservice.DataTypes;
using EasyMicroservices.Domain.DataTypes;
using System;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities
{
    public class PersonEntity : PersonSchema, IIdSchema<long>
    {
        public long Id { get; set; }

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

