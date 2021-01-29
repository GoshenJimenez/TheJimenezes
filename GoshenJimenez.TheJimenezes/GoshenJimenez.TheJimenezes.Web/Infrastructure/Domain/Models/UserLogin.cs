using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class UserLogin  : BaseModel
    {
        [Required]
        public Guid? UserId { get; set; }
        public User User { get; set; }

        [MaxLength(20)]
        public string Key { get; set; }

        [MaxLength(1000)]
        public string Value { get; set; }

        [Required]
        public LoginType LoginType { get; set; }

    }
}
