using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo12.Verification
{
    public class CreateUpDateDepartmentDto
    {
        /// <summary>
        /// 部们ID
        /// </summary>
        //public int DepartmentId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        [Required]
        public string DepartmenName { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        [Required]
        public string DepartmenCode { get; set; }
        /// <summary>
        /// 父级id
        /// </summary>
        [Required]
        public int DepartmenTid { get; set; }
    }
}
