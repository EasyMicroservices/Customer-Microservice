using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Addresses;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Addresses;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class AddressController : BaseController<AddressEntity, CreateAddressRequestContract, UpdateAddressRequestContract, AddressContract, AddressLanguageContract, long>
    {
        public AddressController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}