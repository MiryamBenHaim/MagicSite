using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.repository
{
    public class PictureDTO
    {
        public int PicId { get; set; }

        public string PicName { get; set; } = null!;

        public int PicProdId { get; set; }
        //{
        public int ProdGeneralId { get; set; }
        //{
        // public string? GenProdName {get; set;}
        //}

        public int ProdColorId { get; set; }
        //{
        //public byte[] ColorName { get; set; } = null!;
        //}

        public string ProdName { get; set; } = null!;

        public string? ProdDesc { get; set; }

        public double ProdPrice { get; set; }

        public int ProdQty { get; set; }

        public bool ProdInStack { get; set; }

        public string ProdStatus { get; set; } = null!;

        public string ProdPic { get; set; } = null!;

        public bool ProdInSale { get; set; }

        public double? ProdSalePrice { get; set; }
        //}
  


    }
}
