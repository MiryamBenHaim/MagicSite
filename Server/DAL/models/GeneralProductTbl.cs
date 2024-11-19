using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class GeneralProductTbl
    {
        public GeneralProductTbl()
        {
            CategoryProductTbls = new HashSet<CategoryProductTbl>();
            ProductTbls = new HashSet<ProductTbl>();
        }

        public int GenProdId { get; set; }
        public string GenProdName { get; set; } = null!;

        public virtual ICollection<CategoryProductTbl> CategoryProductTbls { get; set; }
        public virtual ICollection<ProductTbl> ProductTbls { get; set; }
    }
}
