using System;
using System.Diagnostics;
using Artist.Data;
using Artist.Service;
using Microsoft.AspNetCore.Mvc;
using BoundedContext.Models;

namespace BoundedContext.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArtistContext _artistContext;
        private readonly IArtistService _artistService;

        public HomeController(ArtistContext artistContext, IArtistService artistService)
        {
            _artistContext = artistContext;
            _artistService = artistService;
        }
        public IActionResult Index()
        {
            var res = _artistService.SomeUsefulMethod(Guid.Parse("F44FC5FC-909C-4B86-9E4F-05D6BB8E604A"));
            return View(_artistContext.Artists);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
