using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class Rating : BaseModel
    {
        [Required]
        public Guid? PostId { get; set; }
        public Post Post { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
        public bool MaskUser { get; set; }
        public decimal Score { get; set; }
        public bool IsCounted { get; set; }
    }
}
