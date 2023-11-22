using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.CustomerMicroservice.DataTypes;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class PersonSchema : FullAbilitySchema
    {
        public PersonType Type { get; set; }
        public string Description { get; set; }
    }
}
