using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Chats
{
    public class IndexViewModel
    {
        public List<ChatThreadViewModel> ChatThreads { get; set; }

        public List<ChatMessageViewModel> ChatMessages { get; set; }

        public Guid? UserId { get; set; }
    }
}
