﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace FootballApp2.Controllers
{
    public class DiagramsController : Controller
    {
        [FeatureGate("Diagrams")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
