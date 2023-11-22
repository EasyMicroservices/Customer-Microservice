using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Phones;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Phones;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PhoneController : BaseController<PhoneEntity, CreatePhoneRequestContract, UpdatePhoneRequestContract, PhoneContract, PhoneLanguageContract, long>
    {
        public PhoneController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}