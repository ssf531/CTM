using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CTM.EntityFrameworkCore;
using CTM.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CTM.Web.Tests
{
    [DependsOn(
        typeof(CTMWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CTMWebTestModule : AbpModule
    {
        public CTMWebTestModule(CTMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CTMWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CTMWebMvcModule).Assembly);
        }
    }
}