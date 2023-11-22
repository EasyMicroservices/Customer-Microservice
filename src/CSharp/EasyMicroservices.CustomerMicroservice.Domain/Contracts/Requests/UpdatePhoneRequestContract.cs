namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdatePhoneRequestContract : CreatePhoneRequestContract
    {
        public long Id { get; set; }
    }
}
