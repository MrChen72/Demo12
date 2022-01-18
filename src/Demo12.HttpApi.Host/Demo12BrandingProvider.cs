using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Demo12;

[Dependency(ReplaceServices = true)]
public class Demo12BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Demo12";
}
