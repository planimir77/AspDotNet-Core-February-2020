using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FDMC.Web.Models;
using FDMC.Web.Models.Home;
using FDMC.Web.Services;

namespace FDMC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IGetAllCatsService getAllCatsService;

        public HomeController(ILogger<HomeController> logger, IGetAllCatsService getAllCatsService)
        {
            this.logger = logger;
            this.getAllCatsService = getAllCatsService;
        }

        public IActionResult Index()
        {
            var model = this.getAllCatsService.GetAllCats();
            
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
