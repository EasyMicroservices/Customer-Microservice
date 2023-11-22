using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Emails;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Emails;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class EmailController : BaseController<EmailEntity, CreateEmailRequestContract, UpdateEmailRequestContract, EmailContract, EmailLanguageContract, long>
    {
        public EmailController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }
    }
}