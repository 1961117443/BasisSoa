﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasisSoa.Api.ViewModels.Sys
{
    /// <summary>
    /// 角色详情
    /// </summary>
    public class DetailsSysRoleDto:EditSysRoleDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 用户组织名称
        /// </summary>
        public string OrganizeName { get; set; }
    }
}
