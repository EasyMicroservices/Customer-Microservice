using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.CustomerMicroservice.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities
{
    public class PersonCategoryEntity : PersonCategorySchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public ICollection<PersonEntity> Persons { get; set; }
    }
}
