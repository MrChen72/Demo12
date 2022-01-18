using System;
using System.Collections.Generic;
using System.Text;
using Demo12.Localization;
using Volo.Abp.Application.Services;

namespace Demo12;

/* Inherit your application services from this class.
 */
public abstract class Demo12AppService : ApplicationService
{
    protected Demo12AppService()
    {
        LocalizationResource = typeof(Demo12Resource);
    }
}
