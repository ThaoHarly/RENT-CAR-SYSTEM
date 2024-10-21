﻿using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Customer
{
    public string LicenseId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Class { get; set; } = null!;

    public DateOnly Expire { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<RentalAgreement> RentalAgreements { get; set; } = new List<RentalAgreement>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual User User { get; set; } = null!;
}
