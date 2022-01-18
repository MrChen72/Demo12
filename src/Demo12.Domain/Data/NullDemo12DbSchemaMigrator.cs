using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Demo12.Data;

/* This is used if database provider does't define
 * IDemo12DbSchemaMigrator implementation.
 */
public class NullDemo12DbSchemaMigrator : IDemo12DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
