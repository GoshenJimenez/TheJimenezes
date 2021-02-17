using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Feedback
{
    public class CommentWithRatingViewModel
    {

        public Guid? PostId { get; set; }
        public string Comment { get; set; }

        public decimal Score { get; set; }
    }
}
