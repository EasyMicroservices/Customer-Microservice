namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Addresses
{
    public class UpdateAddressRequestContract : CreateAddressRequestContract
    {
        public long Id { get; set; }
    }
}
