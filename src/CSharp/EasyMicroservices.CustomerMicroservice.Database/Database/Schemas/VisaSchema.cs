using EasyMicroservices.Cores.Database.Schemas;
using System;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class VisaSchema : FullAbilitySchema
    {
        public DateOnly EntryDate { get; set; }
        public DateOnly ExitDate { get; set; }
        public int Duration { get; set; }
    }
}
