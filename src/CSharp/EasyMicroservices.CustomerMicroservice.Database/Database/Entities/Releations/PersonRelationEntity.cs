using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.CustomerMicroservice.DataTypes;

namespace EasyMicroservices.CustomerMicroservice.Database.Entities.Releations
{
    public class PersonRelationEntity : FullAbilitySchema
    {
        public PersonRelationType Type { get; set; }
        public long FromPersonId { get; set; }
        public long ToPersonId { get; set; }

        public PersonEntity FromPerson { get; set; }
        public PersonEntity ToPerson { get; set; }
    }
}
