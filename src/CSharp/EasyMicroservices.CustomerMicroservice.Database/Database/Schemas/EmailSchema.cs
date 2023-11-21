using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class EmailSchema : FullAbilitySchema
    {
        /// <summary>
        /// email address
        /// </summary>
        public string Address { get; set; }
    }
}
