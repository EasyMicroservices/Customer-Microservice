namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdatePersonRequestContract : CreatePersonRequestContract
    {
        public long Id { get; set; }
    }
}
