using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class ProductOrderTbl
    {
        public int PoId { get; set; }
        public int PoOrdId { get; set; }
        public int PoProdId { get; set; }
        public string? PoNote { get; set; }
        public int PoCityId { get; set; }
        public string PoAddress { get; set; } = null!;
        public int PoUserId { get; set; }
        public string PoNameGet { get; set; } = null!;

        public virtual CityTbl PoCity { get; set; } = null!;
        public virtual OrdersTbl PoOrd { get; set; } = null!;
        public virtual ProductTbl PoProd { get; set; } = null!;
        public virtual UserTbl PoUser { get; set; } = null!;
    }
}
