using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Addresses
{
    public class AddressBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public string PostalCode { get; set; }
        public string Address { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
