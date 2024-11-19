using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class PictureTbl
    {
        public int PicId { get; set; }
        public string PicName { get; set; } = null!;
        public int PicProdId { get; set; }

        public virtual ProductTbl PicProd { get; set; } = null!;
    }
}
