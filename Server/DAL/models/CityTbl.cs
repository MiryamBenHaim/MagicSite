using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class CityTbl
    {
        public CityTbl()
        {
            ProductOrderTbls = new HashSet<ProductOrderTbl>();
            UserTbls = new HashSet<UserTbl>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public double CityShippPrice { get; set; }

        public virtual ICollection<ProductOrderTbl> ProductOrderTbls { get; set; }
        public virtual ICollection<UserTbl> UserTbls { get; set; }
    }
}
