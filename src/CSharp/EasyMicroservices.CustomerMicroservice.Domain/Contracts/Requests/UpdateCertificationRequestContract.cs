namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class UpdateCertificationRequestContract : CreateCertificationRequestContract
    {
        public long Id { get; set; }
    }
}
