using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class AddressSchema : FullAbilitySchema
    {
        public string PostalCode { get; set; }
    }
}
