using EasyMicroservices.Cores.Contracts.Requests;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Requests
{
    public class GetByIdAndLanguageRequestContract<T> : GetIdRequestContract<T>
    {
        public string Language { get; set; }
    }
}
