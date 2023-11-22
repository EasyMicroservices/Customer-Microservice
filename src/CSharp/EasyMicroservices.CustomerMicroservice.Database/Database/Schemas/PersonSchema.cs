using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.CustomerMicroservice.DataTypes;
using EasyMicroservices.Domain.DataTypes;
using System;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class PersonSchema : FullAbilitySchema
    {
        public string NationalCode { get; set; }
        public GenderType? GenderType { get; set; }
        public NationalityType? NationalityType { get; set; }
        public MaritalStatusType? MaritalStatus { get; set; }
        public DateOnly? BirthDate { get; set; }
        public RoleOnSiteType? RoleOnSiteType { get; set; }
        public PersonType Type { get; set; }
        public string Description { get; set; }
    }
}
