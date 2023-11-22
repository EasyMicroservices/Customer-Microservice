using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.CustomerMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class CreatePersonRequestContract : PersonBaseContract
    {
        [ContentLanguage(nameof(PersonContract.FirstName))]
        public List<LanguageDataContract> FirstNames { get; set; }

        [ContentLanguage(nameof(PersonContract.LastName))]
        public List<LanguageDataContract> LastNames { get; set; }
    }
}