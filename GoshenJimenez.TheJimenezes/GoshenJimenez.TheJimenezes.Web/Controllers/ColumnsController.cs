using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain;
using GoshenJimenez.TheJimenezes.Web.Infrastructure.Localization;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Columns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Controllers
{
    public class ColumnsController : Controller
    {
        private readonly ILogger<ColumnsController> _logger;
        private readonly IStringLocalizer _localizer;
        private readonly DefaultDbContext _context;
        public ColumnsController(ILogger<ColumnsController> logger, IStringLocalizerFactory factory, DefaultDbContext context)
        {
            var type = typeof(StringResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("StringResource", assemblyName.Name);
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("columns/{id}")]
        public IActionResult Column(Guid? id)
        {
            var column = _context.Columns.FirstOrDefault(c => c.Id == id);

            if(column != null)
            {
                var posts = _context.Posts.Where(p => p.ColumnId == id).OrderByDescending(p => p.CreatedAt).Take(5)
                                    .Select(p => new PostViewModel()
                                    {
                                        Id = p.Id,
                                        Author = p.Author,
                                        SubTitle = p.SubTitle,
                                        Title = p.Title
                                    }).ToList();

                return View(new ColumnViewModel()
                {
                    Id = column.Id,
                    SubTitle = column.SubTitle,
                    Title = column.Title,
                    CreatedAt = column.CreatedAt,
                    IconUrl = column.IconUrl,
                    Posts = posts
                });
            }

            return View();
        }
    }
}
