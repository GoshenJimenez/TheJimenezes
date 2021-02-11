using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Columns
{
    public class PostViewModel : Post
    {

    }

    public class ColumnViewModel : Column
    {
        public List<PostViewModel> Posts { get; set; } 
    }
}
