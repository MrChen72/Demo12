using Volo.Abp.Settings;

namespace Demo12.Settings;

public class Demo12SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Demo12Settings.MySetting1));
    }
}
