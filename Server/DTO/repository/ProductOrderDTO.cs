using System;
using System.Collections.Generic;

namespace DTO.repository;

public class ProductOrderDTO
{
    public int PoId { get; set; }

    public int PoOrdId { get; set; }
    public int OrdUserId { get; set; }
    //user???????????
    //public string UserName { get; set; } = null!;
    //public string UserPhone { get; set; } = null!;
    //public string UserEmail { get; set; } = null!;
    //public string UserPass { get; set; } = nubll!;
    //public int? UserCityId { get; set; }
    //(public string CityName { get; set; } = null!;
    //public double CityShippPrice { get; set; })
    //public string? UserAddress { get; set; }
    public DateTime OrdDate { get; set; }
    public string OrdStatus { get; set; } = null!;
    public DateTime? OrdDateSend { get; set; }
    public double OrdTotalPayment { get; set; }



    public int PoProdId { get; set; }
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


    public string? PoNote { get; set; }
    //address
    public int PoCityId { get; set; }
    public string CityName { get; set; } = null!;
    public double CityShippPrice { get; set; }
    public string PoAddress { get; set; } = null!;
    //user...
    public int PoUserId { get; set; }
    public string UserName { get; set; } = null!;
    public string UserPhone { get; set; } = null!;
    public string UserEmail { get; set; } = null!;
    public string UserPass { get; set; } = null!;
    public int? UserCityId { get; set; }
    public string? UserAddress { get; set; }
    public string PoNameGet { get; set; } = null!;
}
