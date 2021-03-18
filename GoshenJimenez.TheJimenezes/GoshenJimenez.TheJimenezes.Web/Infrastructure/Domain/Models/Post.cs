using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class Post : BaseModel
    {
        [MaxLength(75)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string SubTitle { get; set; }

        [MaxLength(30)]
        public string Author { get; set; }

        public Guid? UserId { get; set; }

        public User User { get; set; }

        [MaxLength(5000)]
        public string Content { get; set; }

        [Required]
        public Guid? ColumnId { get; set; }

        public Column Column { get; set; }

        public bool IsStarred { get; set; }

        public int Likes { get; set; }
        public decimal Rating { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }

        public bool MembersOnly { get; set; }

        [MaxLength(500)]
        public string BannerUrl { get; set; }

        [MaxLength(75)]
        public string Layout { get; set; }
        public bool LikesEnabled { get; set; }
        public bool RatingsEnabled { get; set; }
        public bool CommentsEnabled { get; set; }
        public PostStatus Status {get;set;}

        [Required]
        public PostType Type { get; set; }
    }
}
