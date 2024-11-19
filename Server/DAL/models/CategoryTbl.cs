using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class CategoryTbl
    {
        public CategoryTbl()
        {
            CategoryProductTbls = new HashSet<CategoryProductTbl>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; } = null!;

        public virtual ICollection<CategoryProductTbl> CategoryProductTbls { get; set; }
    }
}
