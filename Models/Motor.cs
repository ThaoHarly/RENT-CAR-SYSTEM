using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Motor
{
    public string MotorId { get; set; } = null!;

    public string VehicleId { get; set; } = null!;

    public string MotorcycleType { get; set; } = null!;

    public string MotorImage { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
