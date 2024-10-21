using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Nationality { get; set; }

    public string UserType { get; set; } = null!;

    public virtual Admin? Admin { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Notification> NotificationReceivers { get; set; } = new List<Notification>();

    public virtual ICollection<Notification> NotificationSenders { get; set; } = new List<Notification>();

    public virtual VehicleHireService? VehicleHireService { get; set; }
}
