﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class FoxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}