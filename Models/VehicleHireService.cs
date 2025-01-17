﻿using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class VehicleHireService
{
    public string UserId { get; set; } = null!;

    public string ServiceType { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankAccount { get; set; } = null!;

    public virtual Business? Business { get; set; }

    public virtual Individual? Individual { get; set; }

    public virtual ICollection<RentalAgreement> RentalAgreements { get; set; } = new List<RentalAgreement>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
