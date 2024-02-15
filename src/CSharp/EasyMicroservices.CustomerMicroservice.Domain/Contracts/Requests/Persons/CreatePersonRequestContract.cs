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
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Addresses;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Certifications;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Emails;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Links;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Passports;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Phones;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Visas;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Persons
{
    public class CreatePersonRequestContract : PersonBaseContract
    {
        [ContentLanguage(nameof(PersonContract.FirstName))]
        public List<LanguageDataContract> FirstNames { get; set; }

        [ContentLanguage(nameof(PersonContract.LastName))]
        public List<LanguageDataContract> LastNames { get; set; }

        public List<UpdateAddressRequestContract> Addresses { get; set; }
        public List<UpdateEmailRequestContract> Emails { get; set; }
        public List<UpdatePassportRequestContract> Passports { get; set; }
        public List<UpdatePhoneRequestContract> Phones { get; set; }
        public List<UpdateCertificationRequestContract> Certifications { get; set; }
        public List<UpdateVisaRequestContract> Visas { get; set; }
        public List<UpdateLinkRequestContract> Links { get; set; }
    }
}