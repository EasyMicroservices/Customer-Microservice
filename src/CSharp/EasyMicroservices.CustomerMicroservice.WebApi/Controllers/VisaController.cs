using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Visas;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Visas;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class VisaController : MultilingualSimpleQueryServiceController<VisaEntity, CreateVisaRequestContract, UpdateVisaRequestContract, VisaContract, VisaLanguageContract, long>
    {
        public VisaController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}