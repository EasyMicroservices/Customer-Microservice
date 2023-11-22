using EasyMicroservices.CustomerMicroservice.Database.Schemas;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities
{
    public class AddressEntity : AddressSchema
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public PersonEntity Person { get; set; }
    }
}
