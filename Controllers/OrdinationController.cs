﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Controllers
{
    public class OrdinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
