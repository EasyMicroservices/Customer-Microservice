using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.Database.Schemas;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities
{
    public class EmailEntity : EmailSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public PersonEntity Person { get; set; }
    }
}
