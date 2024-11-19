using System;
using System.Collections.Generic;

namespace DTO.repository;

public class CategoryProductDTO
{
    public int CpId { get; set; }

    public int CpCatId { get; set; }
    public string CatName { get; set; } = null!;


    public int  CpGenProdId { get; set; }
    public string GenProdName { get; set; } = null!;

}
