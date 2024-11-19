using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class OrdersTbl
    {
        public OrdersTbl()
        {
            ProductOrderTbls = new HashSet<ProductOrderTbl>();
        }

        public int OrdId { get; set; }
        public int OrdUserId { get; set; }
        public DateTime OrdDate { get; set; }
        public string OrdStatus { get; set; } = null!;
        public DateTime? OrdDateSend { get; set; }
        public double OrdTotalPayment { get; set; }

        public virtual UserTbl OrdUser { get; set; } = null!;
        public virtual ICollection<ProductOrderTbl> ProductOrderTbls { get; set; }
    }
}
