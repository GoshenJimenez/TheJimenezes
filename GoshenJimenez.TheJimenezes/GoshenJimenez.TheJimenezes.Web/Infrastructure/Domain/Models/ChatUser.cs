using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class ChatUser : BaseModel
    {
        public Guid? UserId { get; set; }

        public User User { get; set; }

        public Guid? ChatThreadId { get; set; }

        public ChatThread ChatThread { get; set; }
    }
}
