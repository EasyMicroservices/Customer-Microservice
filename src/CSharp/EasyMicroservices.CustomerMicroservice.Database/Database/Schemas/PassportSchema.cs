using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.Domain.DataTypes;
using System;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class PassportSchema : FullAbilitySchema
    {
        public string CountryShortName { get; set; }
        public NationalityType HolderNationalityType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Number { get; set; }
    }
}
