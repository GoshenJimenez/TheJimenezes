using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Posts;

namespace GoshenJimenez.TheJimenezes.Web.Areas.Manage.ViewModels.Posts
{
    public class IndexViewModel
    {
        public List<PostViewModel> Items { get; set; }

        public Guid? ColumnId { get; set; }
    }
}
