using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.DataTypes;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Phones
{
    public class PhoneBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public string Number { get; set; }
        public PhoneNumberType NumberType { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
