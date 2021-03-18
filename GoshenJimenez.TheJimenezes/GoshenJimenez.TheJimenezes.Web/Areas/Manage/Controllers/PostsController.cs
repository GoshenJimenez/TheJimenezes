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

namespace GoshenJimenez.TheJimenezes.Web.Areas.Manage.Controllers
{
    [Area("manage")]
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

        [HttpGet("/manage/posts")]
        public IActionResult Index(int pageIndex = 1, int pageSize = 10, string keyword = "", Guid? columnId = null)
        {
            var posts = _context.Posts.Where(p => p.ColumnId == columnId).OrderByDescending(p => p.CreatedAt).Take(5)
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Author = p.Author,
                    SubTitle = p.SubTitle,
                    Title = p.Title,
                    Status = p.Status
                }).ToList();

            return View(new GoshenJimenez.TheJimenezes.Web.Areas.Manage.ViewModels.Posts.IndexViewModel()
            {
                Items = posts,
                ColumnId = columnId
            });
        }

        [HttpPost("/manage/posts/change-status")]
        public IActionResult ChangeStatus(ChangeStatusViewModel model)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == model.PostId);

            if(post != null)
            {
                post.Status = model.Status;

                _context.Posts.Update(post);
                _context.SaveChanges();
            }

            //Post to Hub

            return RedirectPermanent("~/manage/posts?columnId=" + model.ColumnId);
        }
    }
}
