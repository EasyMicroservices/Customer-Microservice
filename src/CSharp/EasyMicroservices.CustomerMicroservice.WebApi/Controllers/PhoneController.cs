using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests;
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