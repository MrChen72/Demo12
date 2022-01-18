﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo12.Verification
{
    public class CreateUpDateRoleModelDto
    {
        /// <summary>
        /// 角色id
        /// </summary>
        // public int RoleId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        public string RoleName { get; set; }
        /// <summary>
        /// 角色详情
        /// </summary>
        [Required]
        public string RoleDateil { get; set; }
    }
}
