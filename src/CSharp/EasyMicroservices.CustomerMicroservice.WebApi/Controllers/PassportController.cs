using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Passports;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Passports;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PassportController : MultilingualSimpleQueryServiceController<PassportEntity, CreatePassportRequestContract, UpdatePassportRequestContract, PassportContract, PassportLanguageContract, long>
    {
        public PassportController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}