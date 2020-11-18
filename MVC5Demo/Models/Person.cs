﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Demo.Models
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessageResourceName = "Person_Name_Required", ErrorMessageResourceType = typeof(Resource1))] 
        public string Name { get; set; }

        [DisplayName("年齡")]
        [Required(ErrorMessage = "請輸入年紀")]
        [Range(18,99, ErrorMessage = "年紀範圍18~99")]
        public int Age { get; set; }
    }
}