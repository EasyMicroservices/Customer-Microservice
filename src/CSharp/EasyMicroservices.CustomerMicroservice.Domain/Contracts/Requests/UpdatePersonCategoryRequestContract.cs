namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdatePersonCategoryRequestContract : CreatePersonCategoryRequestContract
    {
        public long Id { get; set; }
    }
}
