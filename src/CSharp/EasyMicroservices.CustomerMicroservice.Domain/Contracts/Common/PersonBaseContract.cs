using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.DataTypes;
using EasyMicroservices.Domain.DataTypes;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common
{
    public class PersonBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public string NationalCode { get; set; }
        public GenderType? GenderType { get; set; }
        public NationalityType? NationalityType { get; set; }
        public MaritalStatusType? MaritalStatus { get; set; }
        public DateOnly? BirthDate { get; set; }
        public RoleOnSiteType? RoleOnSiteType { get; set; }
        public PersonType Type { get; set; }

        public string Description { get; set; }
        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }

        public long? CategoryId { get; set; }

        public long? CityId { get; set; }
        public long? CountryId { get; set; }
        public long? ProvinceId { get; set; }
    }
}
