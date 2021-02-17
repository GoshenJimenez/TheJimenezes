using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain;
using GoshenJimenez.TheJimenezes.Web.Infrastructure.Localization;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Posts;
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
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;
        private readonly IStringLocalizer _localizer;
        private readonly DefaultDbContext _context;
        public PostsController(ILogger<PostsController> logger, IStringLocalizerFactory factory, DefaultDbContext context)
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

        [HttpGet("posts/{id}")]
        public IActionResult Post(Guid? id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (post != null)
            {
                return View(new PostViewModel()
                {
                    Id = post.Id,
                    Author = post.Author,
                    SubTitle = post.SubTitle,
                    Title = post.Title,
                    Content = post.Content
                });
            }
            return NotFound();
        }
    }
}
