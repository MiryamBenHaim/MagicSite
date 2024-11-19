using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class ColorTbl
    {
        public ColorTbl()
        {
            ProductTbls = new HashSet<ProductTbl>();
        }

        public int ColorId { get; set; }
        public byte[] ColorName { get; set; } = null!;

        public virtual ICollection<ProductTbl> ProductTbls { get; set; }
    }
}
