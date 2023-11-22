using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Visas
{
    public class VisaBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public DateOnly? EntryDate { get; set; }
        public DateOnly? ExitDate { get; set; }
        public int? Duration { get; set; }
        public string Number { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
