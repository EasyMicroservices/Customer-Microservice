namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdateEmailRequestContract : CreateEmailRequestContract
    {
        public long Id { get; set; }
    }
}
