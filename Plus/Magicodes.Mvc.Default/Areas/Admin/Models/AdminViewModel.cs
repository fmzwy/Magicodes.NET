﻿using Magicodes.Web.Interfaces.T4;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//======================================================================
//
//        Copyright (C) 2014-2016 Magicodes团队    
//        All rights reserved
//
//        filename :AdminViewModel
//        description :
//
//        created by 雪雁 at  2014/10/27 14:14:20
//        http://www.magicodes.net
//
//======================================================================
namespace Magicodes.Mvc.Default.Areas.Admin.Models
{
    [T4ODataGridAttribute("Roles")]
    [Serializable]
    public class RoleViewModel
    {
        [T4GenerationIgnoreAttribute]
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "角色名")]
        public string Name { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}