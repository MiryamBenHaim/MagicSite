using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class CategoryProductTbl
    {
        public int CpId { get; set; }
        public int CpCatId { get; set; }
        public int CpGenProdId { get; set; }

        public virtual CategoryTbl CpCat { get; set; } = null!;
        public virtual GeneralProductTbl CpGenProd { get; set; } = null!;
    }
}
