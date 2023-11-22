namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Emails
{
    public class UpdateEmailRequestContract : CreateEmailRequestContract
    {
        public long Id { get; set; }
    }
}
