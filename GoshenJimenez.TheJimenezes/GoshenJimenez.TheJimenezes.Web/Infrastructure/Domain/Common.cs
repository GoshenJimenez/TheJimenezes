using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain
{
    public class Common
    {
        public List<string> ColumnTypes
        {
            get
            {
                return Enum.GetNames(typeof(ColumnType)).ToList();
            }
        }

        public List<string> PostTypes
        {
            get
            {
                return Enum.GetNames(typeof(PostType)).ToList();
            }
        }

        public List<string> UserRoles
        {
            get
            {
                return Enum.GetNames(typeof(UserRole)).ToList();
            }
        }
        public List<string> LoginTypes
        {
            get
            {
                return Enum.GetNames(typeof(LoginType)).ToList();
            }
        }
    }
}
