using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Links;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Links;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class LinkController : MultilingualSimpleQueryServiceController<LinkEntity, CreateLinkRequestContract, UpdateLinkRequestContract, LinkContract, LinkLanguageContract, long>
    {
        public LinkController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}