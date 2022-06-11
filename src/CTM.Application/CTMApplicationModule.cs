using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CTM.Authorization;

namespace CTM
{
    [DependsOn(
        typeof(CTMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CTMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CTMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CTMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
