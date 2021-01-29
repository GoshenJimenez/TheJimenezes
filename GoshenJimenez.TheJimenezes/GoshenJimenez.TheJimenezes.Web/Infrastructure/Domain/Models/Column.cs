using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models
{
    public class Column : BaseModel
    {
        [MaxLength(75)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string SubTitle { get; set; }

        public ColumnType ColumnType { get; set; }

        [MaxLength(500)]
        public string BannerUrl { get; set; }

        [MaxLength(500)]
        public string IconUrl { get; set; }

        [MaxLength(75)]
        public string Layout { get; set; }


    }
}
