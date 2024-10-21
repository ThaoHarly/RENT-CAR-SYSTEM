using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Notification
{
    public string NotificationId { get; set; } = null!;

    public string SenderId { get; set; } = null!;

    public string ReceiverId { get; set; } = null!;

    public string? Message { get; set; }

    public DateOnly? NotificationDate { get; set; }

    public virtual User Receiver { get; set; } = null!;

    public virtual User Sender { get; set; } = null!;
}
