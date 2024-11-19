using System;
using System.Collections.Generic;

namespace DTO.repository;

public class CityDTO
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public double CityShippPrice { get; set; }

}
