namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests.Persons
{
    public class UpdatePersonRequestContract : CreatePersonRequestContract
    {
        public long Id { get; set; }
    }
}
