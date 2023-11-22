using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Addresses;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Certifications;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Emails;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Links;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Passports;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Phones;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Visas;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Persons
{
    public class CreatePersonRequestContract : PersonBaseContract
    {
        [ContentLanguage(nameof(PersonContract.FirstName))]
        public List<LanguageDataContract> FirstNames { get; set; }

        [ContentLanguage(nameof(PersonContract.LastName))]
        public List<LanguageDataContract> LastNames { get; set; }

        public List<AddressBaseContract> Addresses { get; set; }
        public List<EmailBaseContract> Emails { get; set; }
        public List<PassportBaseContract> Passports { get; set; }
        public List<PhoneBaseContract> Phones { get; set; }
        public List<CertificationBaseContract> Certifications { get; set; }
        public List<VisaBaseContract> Visas { get; set; }
        public List<LinkBaseContract> Links { get; set; }
    }
}