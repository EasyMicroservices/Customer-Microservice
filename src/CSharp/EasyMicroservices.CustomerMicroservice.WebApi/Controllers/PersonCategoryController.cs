using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.PersonCategories;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.PersonCategories;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PersonCategoryController : MultilingualSimpleQueryServiceController<PersonCategoryEntity, CreatePersonCategoryRequestContract, UpdatePersonCategoryRequestContract, PersonCategoryContract, PersonCategoryLanguageContract, long>
    {
        public PersonCategoryController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}