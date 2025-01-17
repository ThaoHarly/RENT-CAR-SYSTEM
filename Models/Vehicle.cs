﻿using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Vehicle
{
    public string VehicleId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string LicensePlate { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double PricePerDay { get; set; }

    public double FuelConsumption { get; set; }

    public double Range { get; set; }

    public double EngineCapacity { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Motor? Motor { get; set; }

    public virtual ICollection<RentalAgreement> RentalAgreements { get; set; } = new List<RentalAgreement>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual VehicleHireService User { get; set; } = null!;
}
