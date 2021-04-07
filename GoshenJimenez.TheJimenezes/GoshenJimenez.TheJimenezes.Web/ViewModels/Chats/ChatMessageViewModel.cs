using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Chats
{
    public class ChatMessageViewModel
    {
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime MessageDate { get; set; }
        public string Message { get; set; }
    }
}
