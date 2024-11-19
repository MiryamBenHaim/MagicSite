using System;
using System.Collections.Generic;

namespace DTO.repository;

public class OrdersDTO
{
    public int OrdId { get; set; }

    public int OrdUserId { get; set; }

    public DateTime OrdDate { get; set; }

    public string OrdStatus { get; set; } = null!;

    public DateTime? OrdDateSend { get; set; }

    public double OrdTotalPayment { get; set; }
}
