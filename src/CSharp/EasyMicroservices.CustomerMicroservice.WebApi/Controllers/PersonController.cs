using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PersonController : BaseController<PersonEntity, CreatePersonRequestContract, UpdatePersonRequestContract, PersonContract, PersonLanguageContract, long>
    {
        public PersonController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}