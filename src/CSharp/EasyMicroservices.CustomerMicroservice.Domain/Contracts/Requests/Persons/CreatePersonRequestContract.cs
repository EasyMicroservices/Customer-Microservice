using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Persons
{
    public class CreatePersonRequestContract : PersonBaseContract
    {
        [ContentLanguage(nameof(PersonContract.FirstName))]
        public List<LanguageDataContract> FirstNames { get; set; }

        [ContentLanguage(nameof(PersonContract.LastName))]
        public List<LanguageDataContract> LastNames { get; set; }
    }
}