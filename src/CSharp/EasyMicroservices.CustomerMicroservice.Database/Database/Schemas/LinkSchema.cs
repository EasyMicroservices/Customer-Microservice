using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.CustomerMicroservice.DataTypes;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class LinkSchema : FullAbilitySchema
    {
        public string Address { get; set; }
        public LinkType Type { get; set; }
    }
}
