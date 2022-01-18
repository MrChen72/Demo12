using Demo12.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Demo12.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Demo12Controller : AbpControllerBase
{
    protected Demo12Controller()
    {
        LocalizationResource = typeof(Demo12Resource);
    }
}
