using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Chats
{
    public class ChatThreadViewModel
    {
        public Guid? ChatThreadId { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime LastMessageDate { get; set; }
    }
}
