using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Natter.Authorization;

namespace Natter
{
    [DependsOn(
        typeof(NatterCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NatterApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NatterAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NatterApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
