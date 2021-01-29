using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class Attachment : BaseModel
    {
        [Required]
        public Guid? PostId { get; set; }
        public Post Post { get; set; }

        [MaxLength(500)]
        public string AttachmentUrl { get; set; }

        [MaxLength(20)]
        public string ContentType { get; set; }

        [MaxLength(150)]
        public string Caption { get; set; }
        public int? SortOrder { get; set; }
        public bool IsPublished { get; set; }
        public int Likes { get; set; }
        public bool LikesEnabled { get; set; }
        public bool CommentsEnabled { get; set; }
    }
}
