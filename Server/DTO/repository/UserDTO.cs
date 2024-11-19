using System;
using System.Collections.Generic;

namespace DTO.repository;

public class UserDTO
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPhone { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserPass { get; set; } = null!;

    public int? UserCityId { get; set; }
    public string CityName { get; set; } = null!;
    public double CityShippPrice { get; set; }

    public string? UserAddress { get; set; }

    //NULLמכיוון שאפשרי ל DTO אין המרה ל



}
