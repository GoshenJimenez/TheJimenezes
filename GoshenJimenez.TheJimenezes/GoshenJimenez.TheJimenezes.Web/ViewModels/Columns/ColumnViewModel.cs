﻿using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.ViewModels.Columns
{
    public class ColumnViewModel : Column
    {
        public List<PostViewModel> Posts { get; set; } 
    }
}
