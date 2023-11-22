using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Passports;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Passports;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PassportController : BaseController<PassportEntity, CreatePassportRequestContract, UpdatePassportRequestContract, PassportContract, PassportLanguageContract, long>
    {
        public PassportController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}