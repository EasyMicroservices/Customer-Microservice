using CodeReviewer.Engine;
using EasyMicroservices.CustomerMicroservice.Contracts.Common.Persons;
using EasyMicroservices.CustomerMicroservice.Database.Entities;
using EasyMicroservices.CustomerMicroservice.WebApi.Controllers;
using EasyMicroservices.Tests;

namespace EasyMicroservices.CustomerMicroservice.Tests
{
    public class CodeReviewerCheckTests : CodeReviewerTests
    {
        static CodeReviewerCheckTests()
        {
            //types to check (this will check all of types in assembly so no need to add all of types of assembly)
            AssemblyManager.AddAssemblyToReview(
                typeof(DatabaseBuilder),
                //typeof(CompileTimeClassesMappers),
                typeof(PersonEntity),
                typeof(PersonBaseContract),
                typeof(AddressController));
        }
    }
}