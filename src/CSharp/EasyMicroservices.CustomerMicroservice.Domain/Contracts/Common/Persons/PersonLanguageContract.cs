using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons
{
    public class PersonLanguageContract : PersonBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(PersonContract.FirstName))]
        public List<LanguageDataContract> FirstNames { get; set; }

        [ContentLanguage(nameof(PersonContract.LastName))]
        public List<LanguageDataContract> LastNames { get; set; }

        [ContentLanguage(nameof(PersonContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }
    }
}
