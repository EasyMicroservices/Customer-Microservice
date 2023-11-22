namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.PersonCategories
{
    public class UpdatePersonCategoryRequestContract : CreatePersonCategoryRequestContract
    {
        public long Id { get; set; }
    }
}
