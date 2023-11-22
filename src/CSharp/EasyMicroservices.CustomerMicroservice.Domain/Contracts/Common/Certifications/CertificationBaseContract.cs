using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Certifications
{
    public class CertificationBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? CertificationDateTime { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}