using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MainService.Controllers
{
    [AllowAnonymous]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "api running....";
        }


    }
}