using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            OrdersTbls = new HashSet<OrdersTbl>();
            ProductOrderTbls = new HashSet<ProductOrderTbl>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserPhone { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string UserPass { get; set; } = null!;
        public int? UserCityId { get; set; }
        public string? UserAddress { get; set; }

        public virtual CityTbl? UserCity { get; set; }
        public virtual ICollection<OrdersTbl> OrdersTbls { get; set; }
        public virtual ICollection<ProductOrderTbl> ProductOrderTbls { get; set; }
    }
}
