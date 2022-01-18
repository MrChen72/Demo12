using System.Threading.Tasks;

namespace Demo12.Data;

public interface IDemo12DbSchemaMigrator
{
    Task MigrateAsync();
}
