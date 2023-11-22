using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common
{
    public class PassportBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {

        public string CountryShortName { get; set; }
        public NationalityType HolderNationalityType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Number { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
