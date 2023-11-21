using EasyMicroservices.CustomerMicroservice.Database.Schemas;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities
{
    public class VisaEntity : VisaSchema
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public PersonEntity Person { get; set; }
    }
}
