using Demo12.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demo12;

[DependsOn(
    typeof(Demo12EntityFrameworkCoreTestModule)
    )]
public class Demo12DomainTestModule : AbpModule
{

}
