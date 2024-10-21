using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Car
{
    public string CarId { get; set; } = null!;

    public string VehicleId { get; set; } = null!;

    public string CarBrand { get; set; } = null!;

    public string? FuelType { get; set; }

    public int? SeatingCapacity { get; set; }

    public string? CarImage { get; set; }

    public double? ChargingTime { get; set; }

    public virtual Vehicle Vehicle { get; set; } = null!;
}
