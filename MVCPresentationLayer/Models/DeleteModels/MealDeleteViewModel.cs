﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.DeleteModels
{
    public class MealDeleteViewModel
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
