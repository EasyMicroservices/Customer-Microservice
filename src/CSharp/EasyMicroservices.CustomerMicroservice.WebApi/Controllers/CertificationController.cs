using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Certifications;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Certifications;
using EasyMicroservices.CustomerMicroservice.Database.Entities;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class CertificationController : MultilingualSimpleQueryServiceController<CertificationEntity, CreateCertificationRequestContract, UpdateCertificationRequestContract, CertificationContract, CertificationLanguageContract, long>
    {
        public CertificationController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}