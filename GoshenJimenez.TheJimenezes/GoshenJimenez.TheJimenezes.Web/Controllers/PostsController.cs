using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain;
using GoshenJimenez.TheJimenezes.Web.Infrastructure.Localization;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Comments;
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
            //for now Hard Code the UserId = 0bb8a75f-68ea-4d27-9c5f-81b8cdd9d000
            Guid? userId = Guid.Parse("0bb8a75f-68ea-4d27-9c5f-81b8cdd9d000");

            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (post != null)
            {
                var comments = _context.Comments.Where(c => c.PostId == id && c.IsPublished == true)
                                                .OrderByDescending(c => c.UpdatedAt)
                                                .Take(3)
                                                .Select(c => new ViewModels.Posts.CommentViewModel()
                                                {
                                                    Id = c.Id, 
                                                    UserId = c.UserId,
                                                    Content = c.Content,
                                                    Likes = c.Likes,
                                                    UserName = (c.MaskUser == true ? c.UserName : c.User.FullName),
                                                    UserIcon = (c.MaskUser == true ? "user.svg" : c.User.Id.ToString() + ".jpeg"),
                                                    UpdatedAt = c.UpdatedAt
                                                })
                                                .ToList();

                var ratings = _context.Ratings.Where(r => r.PostId == id && r.IsCounted == true).ToList();
                decimal ratingAve = 0;

                if(ratings != null)
                {
                    if (ratings.Count > 0)
                    {
                        ratingAve = ratings.Average(r => r.Score);
                    }
                }

                var isLiked = false;
                var liked = _context.Likes.FirstOrDefault(l => l.PostId == id && l.UserId == userId);

                if(liked != null)
                {
                    isLiked = true;
                }

                return View(new PostViewModel()
                {
                    Id = post.Id,
                    Author = post.Author,
                    SubTitle = post.SubTitle,
                    Title = post.Title,
                    Content = post.Content,
                    CommentItems = comments,
                    RatingAve = ratingAve,
                    IsLiked = isLiked,
                    Likes = post.Likes
                });
            }
            return NotFound();
        }
    }
}
