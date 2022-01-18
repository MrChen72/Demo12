using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo12.Dto
{
    /// <summary>
    /// 权限Dto
    /// </summary>
    public class PowerModelDto : AuditedEntityDto<int>
    {
        /// <summary>
        /// 权限id
        /// </summary>
        //  public int PowerId { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PowerName { get; set; }
    }
}
