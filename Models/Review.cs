using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Review
{
    public string ReviewId { get; set; } = null!;

    public string? CusId { get; set; }

    public string? VehicleId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public DateOnly? ReviewDate { get; set; }

    public virtual Customer? Cus { get; set; }

    public virtual Vehicle? Vehicle { get; set; }
}
