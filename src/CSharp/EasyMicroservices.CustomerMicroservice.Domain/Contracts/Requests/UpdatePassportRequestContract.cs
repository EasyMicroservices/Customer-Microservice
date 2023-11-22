namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdatePassportRequestContract : CreatePassportRequestContract
    {
        public long Id { get; set; }
    }
}
