using Demo12.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Demo12.Permissions;

public class Demo12PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Demo12Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Demo12Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Demo12Resource>(name);
    }
}
