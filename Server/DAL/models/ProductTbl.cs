using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class ProductTbl
    {
        public ProductTbl()
        {
            PictureTbls = new HashSet<PictureTbl>();
            ProductOrderTbls = new HashSet<ProductOrderTbl>();
        }

        public int ProdId { get; set; }
        public int ProdGeneralId { get; set; }
        public int ProdColorId { get; set; }
        public string ProdName { get; set; } = null!;
        public string? ProdDesc { get; set; }
        public double ProdPrice { get; set; }
        public int ProdQty { get; set; }
        public bool ProdInStack { get; set; }
        public string ProdStatus { get; set; } = null!;
        public string ProdPic { get; set; } = null!;
        public bool ProdInSale { get; set; }
        public double? ProdSalePrice { get; set; }

        public virtual ColorTbl ProdColor { get; set; } = null!;
        public virtual GeneralProductTbl ProdGeneral { get; set; } = null!;
        public virtual ICollection<PictureTbl> PictureTbls { get; set; }
        public virtual ICollection<ProductOrderTbl> ProductOrderTbls { get; set; }
    }
}
