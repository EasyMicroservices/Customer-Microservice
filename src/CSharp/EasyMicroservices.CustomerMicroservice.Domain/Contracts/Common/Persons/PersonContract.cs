using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Addresses;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Certifications;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Emails;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Links;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Passports;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Phones;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Visas;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons
{
    public class PersonContract : PersonBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage]
        public string FirstName { get; set; }

        [ContentLanguage]
        public string LastName { get; set; }

        public List<AddressContract> Addresses { get; set; }
        public List<EmailContract> Emails { get; set; }
        public List<PassportContract> Passports { get; set; }
        public List<PhoneContract> Phones { get; set; }
        public List<CertificationContract> Certifications { get; set; }
        public List<VisaContract> Visas { get; set; }
        public List<LinkContract> Links { get; set; }
    }
}
