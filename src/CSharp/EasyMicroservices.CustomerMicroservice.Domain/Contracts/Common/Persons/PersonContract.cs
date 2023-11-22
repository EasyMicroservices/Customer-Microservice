using EasyMicroservices.ContentsMicroservice.Clients.Attributes;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons
{
    public class PersonContract : PersonBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage]
        public string FirstName { get; set; }

        [ContentLanguage]
        public string LastName { get; set; }

        [ContentLanguage]
        public string Description { get; set; }
    }
}
