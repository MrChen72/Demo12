using Demo12.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Demo12.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Demo12EntityFrameworkCoreModule),
    typeof(Demo12ApplicationContractsModule)
    )]
public class Demo12DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
