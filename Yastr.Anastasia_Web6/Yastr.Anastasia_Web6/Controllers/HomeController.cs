﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Yastr.Anastasia_Web6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
