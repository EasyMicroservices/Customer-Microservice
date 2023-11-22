using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.PersonCategories
{
    public class PersonCategoryLanguageContract : PersonCategoryBaseContract
    {
        public long Id { get; set; }
        [ContentLanguage(nameof(PersonCategoryContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
    }
}
