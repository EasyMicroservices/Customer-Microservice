﻿using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.CustomerMicroservice.DataTypes;

namespace EasyMicroservices.CustomerMicroservice.Database.Schemas
{
    public class PhoneSchema : FullAbilitySchema
    {
        public string Number { get; set; }
        public PhoneNumberType NumberType { get; set; }
    }
}
