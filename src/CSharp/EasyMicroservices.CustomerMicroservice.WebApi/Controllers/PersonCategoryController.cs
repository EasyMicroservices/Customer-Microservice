using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PersonCategoryController : BaseController<PersonCategoryEntity, CreatePersonCategoryRequestContract, UpdatePersonCategoryRequestContract, PersonCategoryContract, PersonCategoryLanguageContract, long>
    {
        public PersonCategoryController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}