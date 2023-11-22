using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.DataTypes;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common
{
    public class PersonCategoryBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
