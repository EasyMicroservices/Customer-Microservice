namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Phones
{
    public class UpdatePhoneRequestContract : CreatePhoneRequestContract
    {
        public long Id { get; set; }
    }
}
