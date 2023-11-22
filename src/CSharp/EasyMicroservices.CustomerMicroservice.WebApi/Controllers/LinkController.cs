using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Links;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Links;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class LinkController : BaseController<LinkEntity, CreateLinkRequestContract, UpdateLinkRequestContract, LinkContract, LinkLanguageContract, long>
    {
        public LinkController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}