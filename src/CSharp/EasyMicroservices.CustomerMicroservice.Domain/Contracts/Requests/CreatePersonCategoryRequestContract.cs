using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.CustomerMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class CreatePersonCategoryRequestContract : PersonCategoryBaseContract
    {

        [ContentLanguage(nameof(PersonCategoryContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
    }
}