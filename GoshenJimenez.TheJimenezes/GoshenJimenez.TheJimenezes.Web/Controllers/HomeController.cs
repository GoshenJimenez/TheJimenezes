using GoshenJimenez.TheJimenezes.Web.Infrastructure.Localization;
using GoshenJimenez.TheJimenezes.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer _localizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizerFactory factory)
        {
            var type = typeof(StringResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("StringResource", assemblyName.Name);
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Welcome = _localizer["WelcomeMessage"].Value;
            ViewBag.Language = CultureInfo.CurrentCulture.DisplayName;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
