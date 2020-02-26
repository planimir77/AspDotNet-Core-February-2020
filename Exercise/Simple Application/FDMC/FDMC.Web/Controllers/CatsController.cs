using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Web.Models;
using FDMC.Web.Models.Cats;
using FDMC.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Web.Controllers
{
    public class CatsController : Controller
    {
        private readonly ICreateCatService _createCatService;
        private readonly ICatDetailsServices _detailsServices;


        public CatsController(ICreateCatService createCatService, ICatDetailsServices detailsServices)
        {
            _createCatService = createCatService;
            _detailsServices = detailsServices;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCatViewModel model)
        {
            var catId = _createCatService.CreateCat(model.Name, model.Age, model.Breed, model.Image);

            return Redirect("/");
        }

        public IActionResult Details(string catId)
        {
            CatDetailsViewModel model = _detailsServices.CatInfo(catId);
            return this.View(model);
        }
    }
}
