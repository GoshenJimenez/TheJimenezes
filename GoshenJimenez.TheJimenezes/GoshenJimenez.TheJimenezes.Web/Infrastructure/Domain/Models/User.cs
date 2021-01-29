using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class User : BaseModel
    {
        [Required]
        [MaxLength(30)]
        public string UserName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        public UserRole Role { get; set; }
        
    }
}
