using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain;
using GoshenJimenez.TheJimenezes.Web.Infrastructure.Localization;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Feedback;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Operation;
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
    public class FeedbackController : Controller
    {
        private readonly ILogger<FeedbackController> _logger;
        private readonly IStringLocalizer _localizer;
        private readonly DefaultDbContext _context;
        public FeedbackController(ILogger<FeedbackController> logger, IStringLocalizerFactory factory, DefaultDbContext context)
        {
            var type = typeof(StringResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("StringResource", assemblyName.Name);
            _logger = logger;
            _context = context;
        }

        [HttpPost("feedback/add-comment-with-rating")] 
        public IActionResult AddCommentWithRating(CommentWithRatingViewModel model)
        {

            //for now Hard Code the UserId = 0bb8a75f-68ea-4d27-9c5f-81b8cdd9d000
            Guid? userId = Guid.Parse("0bb8a75f-68ea-4d27-9c5f-81b8cdd9d000");

            var post = _context.Posts.FirstOrDefault(p => p.Id == model.PostId);

            if(post != null)
            {
                if(post.RatingsEnabled == true)
                {
                    var userRating = _context.Ratings.FirstOrDefault(r => r.UserId == userId && r.PostId == model.PostId);

                    if(userRating == null)
                    {
                        userRating = new Infrastructure.Domain.Models.Rating()
                        {
                            Score = model.Score,
                            PostId = model.PostId,
                            UserId = userId,
                            IsCounted = true,
                            MaskUser = false
                        };

                        _context.Ratings.Add(userRating);
                        _context.SaveChanges();
                    }
                }

                if(post.CommentsEnabled == true)
                {
                    var userComment = new Infrastructure.Domain.Models.Comment()
                    {
                        Content = model.Comment,
                        IsPublished = true,
                        PostId = model.PostId,
                        UserId = userId,
                        MaskUser = false,
                        LikesEnabled = true,
                        Likes = 0,
                    };

                    _context.Comments.Add(userComment);
                    _context.SaveChanges();
                }

                return RedirectPermanent("~/posts/" + model.PostId);
            }

            return NotFound();
        }

        [HttpPost("feedback/likes")]
        public OperationViewModel AddDeductLike(LikeViewModel model)
        {
            //for now Hard Code the UserId = 0bb8a75f-68ea-4d27-9c5f-81b8cdd9d000
            Guid? userId = Guid.Parse("0bb8a75f-68ea-4d27-9c5f-81b8cdd9d000");

            var post = _context.Posts.FirstOrDefault(p => p.Id == model.PostId);

            if (post != null)
            {
                if (post.LikesEnabled == true)
                {
                    var userLike = _context.Likes.FirstOrDefault(r => r.UserId == userId && r.PostId == model.PostId);

                    if(userLike == null && model.IsLiked)
                    {
                        userLike = new Infrastructure.Domain.Models.Like()
                        {
                            PostId = model.PostId,
                            UserId = userId
                        };

                        _context.Likes.Add(userLike);

                        post.Likes = post.Likes + 1;
                        _context.Posts.Update(post);
                    }
                    else if (userLike != null && model.IsLiked == false)
                    {
                        _context.Likes.Remove(userLike);

                        post.Likes = post.Likes - 1;
                        _context.Posts.Update(post);
                    }
                    else
                    {

                    }

                    _context.SaveChanges();
                    return new OperationViewModel()
                    {
                        Code = "Ok",
                        Data = new { Likes = post.Likes, IsLiked = model.IsLiked }
                    };
                }
                else
                {
                    return new OperationViewModel()
                    {
                        Code = "Fail",
                        Messages = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("", "Likes are disabled for this item.") },
                        Data = new { Likes = post.Likes, IsLiked = false }
                    };
                }
            }
            else
            {
                return new OperationViewModel()
                {
                    Code = "Fail",
                    Messages = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("", "Target post is not found.") },
                    Data = new { IsLiked = false }
                };
            }

        }
    }
}
