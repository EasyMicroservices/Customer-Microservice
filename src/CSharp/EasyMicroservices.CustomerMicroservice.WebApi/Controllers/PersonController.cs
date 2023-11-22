using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons;
using EasyMicroservices.CustomerMicroservice.Contracts.Requests.Persons;
using EasyMicroservices.CustomerMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.CustomerMicroservice.WebApi.Controllers
{
    public class PersonController : BaseController<PersonEntity, CreatePersonRequestContract, UpdatePersonRequestContract, PersonContract, PersonLanguageContract, long>
    {
        public PersonController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork, config)
        {
        }

        Func<IQueryable<PersonEntity>, IQueryable<PersonEntity>> GetQuery()
        {
            return q => q
            .Include(x => x.Addresses)
            .Include(x => x.Emails)
            .Include(x => x.Passports)
            .Include(x => x.Phones)
            .Include(x => x.Certifications)
            .Include(x => x.Visas)
            .Include(x => x.Links);
        }

        protected override Func<IQueryable<PersonEntity>, IQueryable<PersonEntity>> OnGetQuery()
        {
            return GetQuery();
        }
    }
}