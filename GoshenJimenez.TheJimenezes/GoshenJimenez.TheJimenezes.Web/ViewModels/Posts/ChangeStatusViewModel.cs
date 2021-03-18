using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Posts
{
    public class ChangeStatusViewModel
    {
       public Guid? PostId { get; set; }
       public PostStatus Status { get; set; }

       public Guid? ColumnId { get; set; }
    }
}
