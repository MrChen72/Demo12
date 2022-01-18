using Volo.Abp.Modularity;

namespace Demo12;

[DependsOn(
    typeof(Demo12ApplicationModule),
    typeof(Demo12DomainTestModule)
    )]
public class Demo12ApplicationTestModule : AbpModule
{

}
