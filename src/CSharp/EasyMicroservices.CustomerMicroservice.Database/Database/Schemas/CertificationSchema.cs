using EasyMicroservices.Cores.Database.Schemas;
using System;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class CertificationSchema : FullAbilitySchema
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? CertificationDateTime { get; set; }
    }
}
