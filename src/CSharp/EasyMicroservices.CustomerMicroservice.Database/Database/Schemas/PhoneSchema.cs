using EasyMicroservices.CustomerMicroservice.DataTypes;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class PhoneSchema
    {
        public string Number { get; set; }
        public PhoneNumberType NumberType { get; set; }
    }
}
