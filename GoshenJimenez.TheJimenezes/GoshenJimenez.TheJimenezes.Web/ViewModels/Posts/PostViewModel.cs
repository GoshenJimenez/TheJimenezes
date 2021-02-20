using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Posts
{
    public class PostViewModel : Post
    {
        public List<CommentViewModel> CommentItems { get; set; }
        public decimal RatingAve { get; set; }
        public bool IsLiked { get; set; }

    }
    public class CommentViewModel 
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public string UserName { get; set; }
        public string UserIcon { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
