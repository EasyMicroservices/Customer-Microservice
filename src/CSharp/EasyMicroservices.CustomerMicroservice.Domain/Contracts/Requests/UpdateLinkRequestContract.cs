namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdateLinkRequestContract : CreateLinkRequestContract
    {
        public long Id { get; set; }
    }
}
