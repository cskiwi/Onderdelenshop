using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Onderdelenshop.EntityFramework;

namespace Onderdelenshop
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(OnderdelenshopCoreModule))]
    public class OnderdelenshopDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<OnderdelenshopDbContext>(null);
        }
    }
}
