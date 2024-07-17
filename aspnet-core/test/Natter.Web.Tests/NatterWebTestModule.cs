using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Natter.EntityFrameworkCore;
using Natter.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Natter.Web.Tests
{
    [DependsOn(
        typeof(NatterWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NatterWebTestModule : AbpModule
    {
        public NatterWebTestModule(NatterEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NatterWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NatterWebMvcModule).Assembly);
        }
    }
}