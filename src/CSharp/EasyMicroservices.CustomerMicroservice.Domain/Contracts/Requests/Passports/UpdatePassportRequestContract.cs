namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Passports
{
    public class UpdatePassportRequestContract : CreatePassportRequestContract
    {
        public long Id { get; set; }
    }
}
