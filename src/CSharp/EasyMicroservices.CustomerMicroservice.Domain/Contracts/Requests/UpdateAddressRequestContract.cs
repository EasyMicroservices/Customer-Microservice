namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdateAddressRequestContract : CreateAddressRequestContract
    {
        public long Id { get; set; }
    }
}
